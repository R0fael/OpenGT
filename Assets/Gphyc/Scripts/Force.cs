using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.TerrainTools;

namespace OpenGT.Gphyc
{
    [Serializable]
    public class Force
    {
        [Serializable]

        // Use it only in standart GT fan game structure
        public class Player
        {
            [Space(32)]
            [Header("Kick")]
            public bool isKick;

            [Space(32)]
            [Header("Cosmetic Change")]
            public bool isCosmeticChange;
            public string cosmetic_type;
            public string cosmetic;

            [Space(32)]
            [Header("Color Change")]
            public bool isColorChange;
            public Color color;

            [Space(32)]
            [Header("Add Character To The Name")]
            public string character;
            public bool isRemove;
        }

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

        public Player player;
    }
}
