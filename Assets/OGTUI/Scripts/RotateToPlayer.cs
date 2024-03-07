using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 x;
    void Update()
    {
        x = Vector3.RotateTowards(transform.position, player.position, 10000f, 10000f);
        transform.rotation = Quaternion.Euler(x);
    }
}
