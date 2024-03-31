using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.VR;
using TMPro;
using System;

namespace OpenGT.PC
{
    public class Computer : MonoBehaviour
    {
        public int id;
        public TextMeshPro ScreenText;
        public string[] textOnScreen = {
        "Name:",
        "Server:",
        "Room:",
        "Color:",
        "",
        "",
        "",
        "",
        "",
        "",
        ""
    };

        public int[] bufferText =
        {
        4,6,4,5
    };

        public Vector2 ScreenResolution = new(25, 11);

        public string pressed;

        private void Start()
        {
            UpdateScreen();
        }

        private void Update()
        {
            if (pressed == "Down")
            {
                id++;
                //pressed = "";
            }
            if (pressed == "Up")
            {
                id--;
                //pressed = "";
            }
            if (pressed == "Delete")
            {
                textOnScreen[id].Remove(textOnScreen[id].Length - 1);
                //pressed = "";
            }
            textOnScreen[id] += pressed;
            //pressed = "";
            UpdateScreen();
        }
        #region Screen Manipulation

        public void Press(string text)
        {
            pressed = text;
        }

        void UpdateScreen()
        {
            ClearScreen();
            foreach (string text in textOnScreen)
            {
                ScreenText.text += text + "\n";
            }
        }

        void ClearScreen()
        {
            ScreenText.text = "";
        }
        #endregion
    }
}
