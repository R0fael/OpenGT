using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Force
{
    public string name;
    public float velocityBump;
    public Vector3 force;

    [Space(32)]
    [Header("TimeStop")]
    public bool isTimeStop;
    public bool TimeStopState;

    [Space(32)]
    [Header("GravityChange")]
    public bool isGravityChange;
    public bool GravityChangeState;

    [Space(32)]
    [Header("MaterialChange")]
    public Material material;
    public PhysicMaterial physicMaterial;
}
