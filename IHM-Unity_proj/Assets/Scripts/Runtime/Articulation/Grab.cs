using UnityEngine;

public class Grab : MonoBehaviour
{
    private bool isObjectGrabbed = false;
    private Rigidbody objectToGrab;
    public bool Pince2Contact = false;

    void OnCollisionEnter(Collision collision)
    {
        /*Debug.Log("collision");
        if (collision.collider.CompareTag("ObjectToGrab") && Pince2Contact && !isObjectGrabbed)
        {
            Debug.Log("in col");
            objectToGrab = collision.collider.GetComponent<Rigidbody>();

            objectToGrab.isKinematic = true;

            objectToGrab.transform.parent = transform;
            isObjectGrabbed = true;
        }*/
    }

    public void ReleaseObject()
    {
        Debug.Log("on release");
        if (isObjectGrabbed)
        {
            objectToGrab.transform.parent = null;
            objectToGrab.isKinematic = false;
            objectToGrab = null;
            isObjectGrabbed = false;
        }
    }
}