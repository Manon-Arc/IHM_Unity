using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArticulationController : MonoBehaviour
{
    public Dictionary<String, ArticulationJointController> Obj;

    public ArticulationJointController axe1Controller;
    public ArticulationJointController axe2Controller;
    public ArticulationJointController pinceController;
    public ArticulationJointController pinceG;
    public ArticulationJointController pinceD;
    public Grab GPince1;

    private void Awake()
    {
        Obj = new Dictionary<string, ArticulationJointController>()
        {
            {"axe1", axe1Controller},
            {"axe2", axe2Controller},
            {"pince", pinceController},
            {"pinceG", pinceG},
            {"pinceD", pinceD}
        };
    }

    public void RotateArticulation(string articulation, int dir)
    {
        RotationDirection direc = (RotationDirection)dir;
        Obj[articulation].rotationState = direc;
    }

    public void StopArticulation(string articulation)
    {
        Obj[articulation].rotationState = RotationDirection.None;
    }

    public void PinceMove(bool move)
    {
        if (move == true)
        {
            Obj["pinceD"].rotationState = RotationDirection.Negative;
            Obj["pinceG"].rotationState = RotationDirection.Positive;
            GPince1.ReleaseObject();
        }
        else
        {
            Obj["pinceD"].rotationState = RotationDirection.Positive;
            Obj["pinceG"].rotationState = RotationDirection.Negative;
        }
    }
}