using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace OpenGT.Gphyc
{
    [Serializable]
    public class Force
    {
        [Serializable]
        public class Physic
        {
            [Tooltip("The Multiplication, That Will Affect The Velocity")]
            public float velocityBump = 1f;
            [Tooltip("The Force, That Will Add To The Object")]
            public Vector3 force;

            [Space(16)]
            [Header("TimeStop")]
            [Tooltip("Enables Time Stop")]
            public bool isTimeStop;
            [Tooltip("The State Of Changing Of Time Stop")]
            public bool TimeStopState;

            [Space(16)]
            [Header("GravityChange")]
            [Tooltip("Enables Gravity Change")]
            public bool isGravityChange;
            [Tooltip("The State Of Gravity Change")]
            public bool GravityChangeState;

            [Space(16)]
            [Header("MaterialChange")]
            [Tooltip("Leave It Empty To Disable The Material Change")]
            public Material material;
            [Tooltip("Leave It Empty To Disable The Material Change")]
            public PhysicMaterial physicMaterial;
        }
        [Serializable]
        public class Player
        {
            [Space(16)]
            [Header("Kick")]
            [Tooltip("Enables Kick")]
            public bool isKick;

            [Space(16)]
            [Header("Cosmetic Change")]
            [Tooltip("Enables Cosmetic Change")]
            public bool isCosmeticChange;
            [Tooltip("The Name Of The Cosmtic Type")]
            public string cosmetic_type;
            [Tooltip("The Name Of The Cosmtic")]
            public string cosmetic;

            [Space(16)]
            [Header("Color Change")]
            [Tooltip("Enables Color Change")]
            public bool isColorChange;
            [Tooltip("The Color the player is changing to")]
            public Color color;

            [Space(16)]
            [Header("Set Name")]
            [Tooltip("Enables Renaming Player's Name")]
            public bool isSetName;
            [Tooltip("The Name, That You Are Changing The Name To")]
            public string name;

            [Space(16)]
            [Header("Change Health")]
            [Tooltip("The Change of Health")]
            public float ChangeHealth;

            [Space(16)]
            [Header("Change Regeneration Speed")]
            [Tooltip("The Change of Regeneration Speed")]
            public float ChangeRegenerationSpeed;

            [Space(16)]
            [Header("Set Health")]
            [Tooltip("Enables Health Setting")]
            public bool isSetHealth;
            [Tooltip("The Value, That Health Will Set To")]
            public float SetHealth;

            [Space(16)]
            [Header("Set Regeneration Speed")]
            [Tooltip("Enables Regeneration Speed Setting")]
            public bool isSetRegenerationSpeed;
            [Tooltip("The Value, That Regeneration Speed Will Set To")]
            public float SetRegenerationSpeed;

            [Space(16)]
            [Header("Change Server")]
            [Tooltip("Enables Server Change")]
            public float IsChangeServer;
            [Tooltip("The Name Of A Server, That You Are Going To Change")]
            public string ServerName;

            [Space(16)]
            [Header("Change Room")]
            [Tooltip("Enables Room Change")]
            public float IsChangeRoom;
            [Tooltip("The Room, That You Are Going To Change")]
            public string RoomName;
        }

        public string name;
        [Space(16)]
        public Physic physic;
        [Space(32)]
        public Player player;
    }
}
