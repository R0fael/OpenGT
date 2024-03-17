using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAndDisable : MonoBehaviour
{
    [Header("Made by R0fael")]

    public bool state;
    public GameObject Object;

    public string HandTag = "HandTag";

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(HandTag))
        {
            Object.SetActive(state);
        }
    }
}
