using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InstanciateClass : MonoBehaviour
{
    public Dictionary<String, (PrimitiveType, GameObject)> Obj;
    
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

    public void Instanciate(string ObjectName)
    {
        GameObject obj = GameObject.CreatePrimitive(Obj[ObjectName].Item1);
        GameObject spawn = Obj[ObjectName].Item2;
        
        obj.transform.position = spawn.transform.position;
        obj.AddComponent<Rigidbody>();
    }
}
