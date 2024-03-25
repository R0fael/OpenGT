using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenGT.Gphyc
{
    public class ForceField : MonoBehaviour
    {
        public Force forceOnEnter;
        public Force forceOnStay;
        public Force forceOnExit;
        public string Tag;
        public Force forceOnEnterTag;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Object>() != null)
            {
                other.gameObject.GetComponent<Object>().Affect(forceOnEnter);
            }

            if (other.CompareTag(Tag))
            {
                Object obj = new();
                obj.Affect(forceOnEnterTag);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.GetComponent<Object>() != null)
            {
                other.gameObject.GetComponent<Object>().Affect(forceOnStay);
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
