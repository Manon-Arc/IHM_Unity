using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementClass : MonoBehaviour
{
    public GameObject bot;
    
    private float rotateSpeedG = -10f;
    private float rotateSpeedD = 10f;

    public float speedAV = 5f;
    public float speedAR = -5f;

    public string canRoule = "stop";
    public string canRota = "stop";
    public void MoveBot(string dir)
    {
        canRoule = dir;
    }

    public void RotaBot(string dir)
    {
        canRota = dir;
    }

    public void MoveBotTrans(string dir)
    {
        ArticulationBody rb = bot.GetComponent<ArticulationBody>();
        
        if (dir == "ar")
        {
            rb.velocity = bot.transform.up * speedAV;
        }
        else
        {
            rb.velocity = bot.transform.up * speedAR;
        }
    }
    
    public void MoveBotRota(string dir)
    {
        Vector3 vec = new Vector3(0, 0.1f, 0);
        ArticulationBody rb = bot.GetComponent<ArticulationBody>();
        
        if (dir == "d")
        {
            rb.angularVelocity = vec * rotateSpeedD; 
        }
        else
        {
            rb.angularVelocity = vec * rotateSpeedG; 
        }
    }

}
