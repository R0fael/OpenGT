using OpenGT.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : MonoBehaviour
{
    public float minutes_per_rotation = 60;

    private void Update()
    {
        transform.rotation = Quaternion.Euler(
            new Vector3(0, 0,
                gameObject.AddComponent<Manager>().RandomByTime(1, 
                    Manager.TimePeriod.minute) * minutes_per_rotation * 15));
    }
}
