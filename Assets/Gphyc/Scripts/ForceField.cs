using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenGT.Gphyc
{
    public class ForceField : MonoBehaviour
    {
        public Force force;
        public Force forceOnExit;
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.GetComponent<Object>() != null)
            {
                other.gameObject.GetComponent<Object>().Affect(force);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.GetComponent<Object>() != null)
            {
                other.gameObject.GetComponent<Object>().Affect(forceOnExit);
            }
        }
    }
}
