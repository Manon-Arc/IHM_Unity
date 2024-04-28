using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabByPince2 : MonoBehaviour
{
    public Command command;
    public ArticulationController ACloc;

    private void Start()
    {
        command = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Command>();
        Debug.Log(command);
        ACloc = command.AC;
        Debug.Log(ACloc);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ObjectToGrab"))
        {
            ACloc.GPince1.Pince2Contact = true;
        }
    }
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ObjectToGrab"))
        {
            ACloc.GPince1.Pince2Contact = false;
        }
    }
}    
