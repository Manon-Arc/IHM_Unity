using System;
using System.Collections;
using UnityEngine;

public class Grab : MonoBehaviour
{
    private bool isObjectGrabbed = false;
    private Rigidbody objectToGrab;
    public bool Pince2Contact = false;
    public Command command;
    public ArticulationController ACloc;


    private void Start()
    {
        command = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Command>();
        ACloc = command.AC;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        if (collision.collider.CompareTag("ObjectToGrab") && Pince2Contact && !isObjectGrabbed)
        {
            Debug.Log("in col");
            objectToGrab = collision.collider.GetComponent<Rigidbody>();

            objectToGrab.isKinematic = true;

            objectToGrab.transform.parent = transform;
            isObjectGrabbed = true;
        }
    }

    public void ReleaseObject()
    {
        Debug.Log("release first");
        StartCoroutine(ReleaseWithDelay());
    }

    public IEnumerator ReleaseWithDelay()
    {
        Debug.Log("on release");
        if (isObjectGrabbed)
        {
            objectToGrab.transform.parent = null;
            objectToGrab.isKinematic = false;
            objectToGrab = null;
            isObjectGrabbed = false;
            ACloc.GPince1.Pince2Contact = false;
            yield return new WaitForSeconds(2f);
        }
    }
}