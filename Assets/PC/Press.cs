using Photon.Voice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenGT.PC
{
    public class Press : MonoBehaviour
    {
        public Computer computer;
        public string HandTag = "HandTag";
        public string Letter;

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Something...");
            if (other.CompareTag(HandTag))
            {
                computer.Press(Letter);
            }
        }
    }
}
