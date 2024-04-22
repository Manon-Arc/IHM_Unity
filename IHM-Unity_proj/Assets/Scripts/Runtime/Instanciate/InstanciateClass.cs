using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = System.Object;

public class InstanciateClass : MonoBehaviour
{
    public Dictionary<string, (PrimitiveType, GameObject)> Obj;
    
    public GameObject spawnCube;
    public GameObject spawnSphere;
    public GameObject spawnCylindre;

    private void Awake()
    {
        Obj = new Dictionary<string, (PrimitiveType, GameObject)>()
        {
            {"cube", (PrimitiveType.Cube, spawnCube)},
            {"sphere", (PrimitiveType.Sphere, spawnSphere)},
            {"cylindre", (PrimitiveType.Cylinder, spawnCylindre)},
        };
    }

    public void Instantiate(string objectName)
    {
        Debug.Log("Attempting to instantiate: " + objectName);
    
        GameObject obj = null;
        GameObject spawn = null;
    
        switch (objectName.ToLower())
        {
            case "cube":
                Debug.Log("Instantiating cube...");
                Debug.Log(obj);
                obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Debug.Log("Object instantiated: " + obj);
                spawn = spawnCube;
                Debug.Log("Spawn point: " + spawn);

                break;
            case "sphere":
                Debug.Log("Instantiating sphere...");
                obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                spawn = spawnSphere;
                break;
            case "cylinder":
                Debug.Log("Instantiating cylinder...");
                obj = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                spawn = spawnCylindre;
                break;
            default:
                Debug.LogError("Unknown object name: " + objectName);
                return;
        }
    
        if (spawn == null)
        {
            Debug.LogError("Spawn point not assigned for " + objectName);
            return;
        }
    
        Debug.Log("Object instantiated: " + obj);
        Debug.Log("Spawn point: " + spawn);
    
        obj.transform.position = spawn.transform.position;
        obj.AddComponent<Rigidbody>();
    
        Debug.Log("Instantiation complete.");
    }
}
