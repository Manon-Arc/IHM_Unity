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
        GameObject obj = GameObject.CreatePrimitive(Obj[objectName].Item1);
        GameObject spawn = Obj[objectName].Item2;
    
        /*switch (objectName.ToLower())
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
        }*/
    
        obj.transform.position = spawn.transform.position;
        obj.AddComponent<Rigidbody>();
        obj.tag = "ObjectToGrab";
    
        Debug.Log("Instantiation complete.");
    }
}
