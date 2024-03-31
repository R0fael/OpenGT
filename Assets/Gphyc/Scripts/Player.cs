using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenGT.Gphyc
{
    public class Player : MonoBehaviour
    {
        [Header("Health")]
        public float Health;
        public float MaxHealth = 1000f;
        public float RegenerationSpeed = 0f;

        private void Update()
        {
            Health += RegenerationSpeed * Time.deltaTime;

            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }

            if (Health < 0)
            {
                Application.Quit();
            }
        }

        public void ChangeHealth(float hp, float reg)
        {
            Health += hp;
            RegenerationSpeed += reg;
        }
    }
}
