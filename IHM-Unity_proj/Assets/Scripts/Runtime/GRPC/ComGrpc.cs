// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Assets/Scripts/proto/com.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class GrpcService
{
  static readonly string __ServiceName = "GrpcService";

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
  {
    #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
    if (message is global::Google.Protobuf.IBufferMessage)
    {
      context.SetPayloadLength(message.CalculateSize());
      global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
      context.Complete();
      return;
    }
    #endif
    context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
  }

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static class __Helper_MessageCache<T>
  {
    public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
  }

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
  {
    #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
    if (__Helper_MessageCache<T>.IsBufferMessage)
    {
      return parser.ParseFrom(context.PayloadAsReadOnlySequence());
    }
    #endif
    return parser.ParseFrom(context.PayloadAsNewBuffer());
  }

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::MoveBotRequest> __Marshaller_MoveBotRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::MoveBotRequest.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::MoveBotResponse> __Marshaller_MoveBotResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::MoveBotResponse.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::RotaBotRequest> __Marshaller_RotaBotRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RotaBotRequest.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::RotaBotResponse> __Marshaller_RotaBotResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RotaBotResponse.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::InstanceObjectRequest> __Marshaller_InstanceObjectRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::InstanceObjectRequest.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::InstanceObjectResponse> __Marshaller_InstanceObjectResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::InstanceObjectResponse.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::TongsManageMoveRequest> __Marshaller_TongsManageMoveRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TongsManageMoveRequest.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::TongsManageMoveResponse> __Marshaller_TongsManageMoveResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TongsManageMoveResponse.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::TongsManageOpeningRequest> __Marshaller_TongsManageOpeningRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TongsManageOpeningRequest.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::TongsManageOpeningResponse> __Marshaller_TongsManageOpeningResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TongsManageOpeningResponse.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::MoveCamRequest> __Marshaller_MoveCamRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::MoveCamRequest.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::MoveCamResponse> __Marshaller_MoveCamResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::MoveCamResponse.Parser));

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::MoveBotRequest, global::MoveBotResponse> __Method_MoveBot = new grpc::Method<global::MoveBotRequest, global::MoveBotResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "MoveBot",
      __Marshaller_MoveBotRequest,
      __Marshaller_MoveBotResponse);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::RotaBotRequest, global::RotaBotResponse> __Method_RotaBot = new grpc::Method<global::RotaBotRequest, global::RotaBotResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "RotaBot",
      __Marshaller_RotaBotRequest,
      __Marshaller_RotaBotResponse);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::InstanceObjectRequest, global::InstanceObjectResponse> __Method_InstanceObject = new grpc::Method<global::InstanceObjectRequest, global::InstanceObjectResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "InstanceObject",
      __Marshaller_InstanceObjectRequest,
      __Marshaller_InstanceObjectResponse);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::TongsManageMoveRequest, global::TongsManageMoveResponse> __Method_TongsManageMove = new grpc::Method<global::TongsManageMoveRequest, global::TongsManageMoveResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "TongsManageMove",
      __Marshaller_TongsManageMoveRequest,
      __Marshaller_TongsManageMoveResponse);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::TongsManageOpeningRequest, global::TongsManageOpeningResponse> __Method_TongsManageOpening = new grpc::Method<global::TongsManageOpeningRequest, global::TongsManageOpeningResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "TongsManageOpening",
      __Marshaller_TongsManageOpeningRequest,
      __Marshaller_TongsManageOpeningResponse);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::MoveCamRequest, global::MoveCamResponse> __Method_MoveCam = new grpc::Method<global::MoveCamRequest, global::MoveCamResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "MoveCam",
      __Marshaller_MoveCamRequest,
      __Marshaller_MoveCamResponse);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::ComReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of GrpcService</summary>
  [grpc::BindServiceMethod(typeof(GrpcService), "BindService")]
  public abstract partial class GrpcServiceBase
  {
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::MoveBotResponse> MoveBot(global::MoveBotRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::RotaBotResponse> RotaBot(global::RotaBotRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::InstanceObjectResponse> InstanceObject(global::InstanceObjectRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::TongsManageMoveResponse> TongsManageMove(global::TongsManageMoveRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::TongsManageOpeningResponse> TongsManageOpening(global::TongsManageOpeningRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::MoveCamResponse> MoveCam(global::MoveCamRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Client for GrpcService</summary>
  public partial class GrpcServiceClient : grpc::ClientBase<GrpcServiceClient>
  {
    /// <summary>Creates a new client for GrpcService</summary>
    /// <param name="channel">The channel to use to make remote calls.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public GrpcServiceClient(grpc::ChannelBase channel) : base(channel)
    {
    }
    /// <summary>Creates a new client for GrpcService that uses a custom <c>CallInvoker</c>.</summary>
    /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public GrpcServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
    {
    }
    /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    protected GrpcServiceClient() : base()
    {
    }
    /// <summary>Protected constructor to allow creation of configured clients.</summary>
    /// <param name="configuration">The client configuration.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    protected GrpcServiceClient(ClientBaseConfiguration configuration) : base(configuration)
    {
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::MoveBotResponse MoveBot(global::MoveBotRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return MoveBot(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::MoveBotResponse MoveBot(global::MoveBotRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_MoveBot, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::MoveBotResponse> MoveBotAsync(global::MoveBotRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return MoveBotAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::MoveBotResponse> MoveBotAsync(global::MoveBotRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_MoveBot, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::RotaBotResponse RotaBot(global::RotaBotRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return RotaBot(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::RotaBotResponse RotaBot(global::RotaBotRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_RotaBot, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::RotaBotResponse> RotaBotAsync(global::RotaBotRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return RotaBotAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::RotaBotResponse> RotaBotAsync(global::RotaBotRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_RotaBot, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::InstanceObjectResponse InstanceObject(global::InstanceObjectRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return InstanceObject(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::InstanceObjectResponse InstanceObject(global::InstanceObjectRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_InstanceObject, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::InstanceObjectResponse> InstanceObjectAsync(global::InstanceObjectRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return InstanceObjectAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::InstanceObjectResponse> InstanceObjectAsync(global::InstanceObjectRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_InstanceObject, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::TongsManageMoveResponse TongsManageMove(global::TongsManageMoveRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return TongsManageMove(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::TongsManageMoveResponse TongsManageMove(global::TongsManageMoveRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_TongsManageMove, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::TongsManageMoveResponse> TongsManageMoveAsync(global::TongsManageMoveRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return TongsManageMoveAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::TongsManageMoveResponse> TongsManageMoveAsync(global::TongsManageMoveRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_TongsManageMove, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::TongsManageOpeningResponse TongsManageOpening(global::TongsManageOpeningRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return TongsManageOpening(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::TongsManageOpeningResponse TongsManageOpening(global::TongsManageOpeningRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_TongsManageOpening, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::TongsManageOpeningResponse> TongsManageOpeningAsync(global::TongsManageOpeningRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return TongsManageOpeningAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::TongsManageOpeningResponse> TongsManageOpeningAsync(global::TongsManageOpeningRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_TongsManageOpening, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::MoveCamResponse MoveCam(global::MoveCamRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return MoveCam(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::MoveCamResponse MoveCam(global::MoveCamRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_MoveCam, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::MoveCamResponse> MoveCamAsync(global::MoveCamRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return MoveCamAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::MoveCamResponse> MoveCamAsync(global::MoveCamRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_MoveCam, null, options, request);
    }
    /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    protected override GrpcServiceClient NewInstance(ClientBaseConfiguration configuration)
    {
      return new GrpcServiceClient(configuration);
    }
  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  public static grpc::ServerServiceDefinition BindService(GrpcServiceBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_MoveBot, serviceImpl.MoveBot)
        .AddMethod(__Method_RotaBot, serviceImpl.RotaBot)
        .AddMethod(__Method_InstanceObject, serviceImpl.InstanceObject)
        .AddMethod(__Method_TongsManageMove, serviceImpl.TongsManageMove)
        .AddMethod(__Method_TongsManageOpening, serviceImpl.TongsManageOpening)
        .AddMethod(__Method_MoveCam, serviceImpl.MoveCam).Build();
  }

  /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
  /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
  /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  public static void BindService(grpc::ServiceBinderBase serviceBinder, GrpcServiceBase serviceImpl)
  {
    serviceBinder.AddMethod(__Method_MoveBot, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::MoveBotRequest, global::MoveBotResponse>(serviceImpl.MoveBot));
    serviceBinder.AddMethod(__Method_RotaBot, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RotaBotRequest, global::RotaBotResponse>(serviceImpl.RotaBot));
    serviceBinder.AddMethod(__Method_InstanceObject, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::InstanceObjectRequest, global::InstanceObjectResponse>(serviceImpl.InstanceObject));
    serviceBinder.AddMethod(__Method_TongsManageMove, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TongsManageMoveRequest, global::TongsManageMoveResponse>(serviceImpl.TongsManageMove));
    serviceBinder.AddMethod(__Method_TongsManageOpening, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TongsManageOpeningRequest, global::TongsManageOpeningResponse>(serviceImpl.TongsManageOpening));
    serviceBinder.AddMethod(__Method_MoveCam, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::MoveCamRequest, global::MoveCamResponse>(serviceImpl.MoveCam));
  }

}
#endregion
