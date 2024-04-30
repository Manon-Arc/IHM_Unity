using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grpc.Core;
using System.Threading.Tasks;

public class Running : MonoBehaviour
{
    static Command task;
    public class GrpcService : global::GrpcService.GrpcServiceBase
    {
        public override Task<MoveBotResponse> MoveBot(MoveBotRequest request, ServerCallContext context)
        {
            string message = $"Moving in the {request.Dir} direction.";
            Debug.Log(message);
            task.MC.MoveBot(request.Dir);
            return Task.FromResult(new MoveBotResponse() { Message = message });
        }
        public override Task<RotaBotResponse> RotaBot(RotaBotRequest request, ServerCallContext context)
        {
            string message = $"Moving in the {request.Dir} direction.";
            Debug.Log(message);
            task.MC.RotaBot(request.Dir);
            return Task.FromResult(new RotaBotResponse() { Message = message });
        }
        
        public override Task<InstanceObjectResponse> InstanceObject(InstanceObjectRequest request, ServerCallContext context)
        {
            string message = $"instantiated object : {request.Object}.";
            Debug.Log(request.Object);
            UnityMainThreadDispatcher.Instance().Enqueue(() =>
            {
                task.IC.Instantiate(request.Object);
            });

            return Task.FromResult(new InstanceObjectResponse() { Message = message });
        }
        
        public override Task<TongsManageMoveResponse> TongsManageMove(TongsManageMoveRequest request, ServerCallContext context)
        {
            string message = $"tongs moving on join {request.JoinName} in {request.Dir}";
            Debug.Log(message);
            task.AC.RotateArticulation(request.JoinName, request.Dir);
            return Task.FromResult(new TongsManageMoveResponse() { Message = message });
        }
        
        public override Task<TongsManageOpeningResponse> TongsManageOpening(TongsManageOpeningRequest request, ServerCallContext context)
        {
            string message = $"tongs opening : {request.Move}";
            Debug.Log(message);
            task.AC.PinceMove(request.Move);
            return Task.FromResult(new TongsManageOpeningResponse() { Message = message });
        }
        
        public override Task<MoveCamResponse> MoveCam(MoveCamRequest request, ServerCallContext context)
        {
            string message = $"Cam moving on : {request.Distance}.";
            Debug.Log(message);
            UnityMainThreadDispatcher.Instance().Enqueue(() =>
            {
                task.MoveCamCommand(request.Distance);
            });
            return Task.FromResult(new MoveCamResponse() { Message = message });
        }
    }

    class ServerStart
    {
        const int Port = 50051;
        const string ipAddress = "0.0.0.0";

        internal void Run()
        {
            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Services = { global::GrpcService.BindService(new GrpcService()) },
                Ports = { new ServerPort(ipAddress, Port, ServerCredentials.Insecure) }
            };
            server.Start();
            Debug.Log("Server listening on " + ipAddress + ":" + Port);
        }
    }

    public void Start()
    {
        task = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Command>();
        ServerStart prg = new ServerStart();
        prg.Run();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space pressed");
            task.AC.PinceMove(true);
        }
    }
}
