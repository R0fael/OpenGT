using Photon.VR;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenGT.Gphyc
{
    [RequireComponent(typeof(Rigidbody))]
    public class Object : MonoBehaviour
    {
        public bool isPlayer;
        public bool isDebugging;

        public Vector3 velocity = Vector3.zero;
        public bool isStopped;


        public Force[] forces;

        private Rigidbody rb;
        private bool isUsingGravity;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            isUsingGravity = rb.useGravity;
        }
        void Update()
        {
            if (isStopped)
            {
                if (velocity == Vector3.zero)
                {
                    velocity = rb.velocity;
                }
                rb.velocity = Vector3.zero;
                rb.useGravity = false;
            }
            else
            {
                if (velocity != Vector3.zero)
                {
                    rb.useGravity = isUsingGravity;
                    rb.velocity = velocity;
                    velocity = Vector3.zero;
                }
            }
        }
        // DO NOT READ IT WILL HURT YOUR EYES
        private void OnTriggerEnter(Collider other)
        {
            foreach (Force force in forces)
            {
                if (other.CompareTag(force.name))
                {
                    Affect(force);
                }
            }
        }

        public void Affect(Force force)
        {
            if (isDebugging)
            {
                Debug.Log(gameObject.name + " was affected by force " + force.name);
            }
            rb.velocity *= force.physic.velocityBump;
            rb.AddForce(force.physic.force);
            if (force.physic.isTimeStop) { isStopped = force.physic.TimeStopState; }

            if (force.physic.isGravityChange) { isUsingGravity = force.physic.GravityChangeState; rb.useGravity = force.physic.GravityChangeState; }

            if (force.physic.material != null && GetComponent<Renderer>()!=null) { GetComponent<Renderer>().material = force.physic.material; }
            if (force.physic.physicMaterial != null) { GetComponent<Collider>().material = force.physic.physicMaterial; }

            if(isPlayer)
            {
                Player player = GetComponent<Player>(); 
                if (player == null)
                {
                    Debug.LogError("You Must Have Player Script On The Player Or Else Most Of Feachures Won'T Work");
                    return;
                }

                player.ChangeHealth(force.player.ChangeHealth, force.player.ChangeRegenerationSpeed);

                if(force.player.isSetHealth)
                {
                    player.Health = force.player.SetHealth;
                }

                if (force.player.isSetRegenerationSpeed)
                {
                    player.RegenerationSpeed = force.player.SetRegenerationSpeed;
                }

                if (force.player.isCosmeticChange) { 
                    PhotonVRManager.SetCosmetic(force.player.cosmetic_type,force.player.cosmetic); 
                }

                if (force.player.isColorChange) {
                    PhotonVRManager.SetColour(force.player.color);
                }

                if (force.player.isKick)
                {
                    Application.Quit();
                }
            }
        }
    }
}
