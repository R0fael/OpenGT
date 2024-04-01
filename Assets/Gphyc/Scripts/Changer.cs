using Photon.VR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changer : MonoBehaviour
{
    public enum Type
    {
        Cosmetic, Color, Scene
    }

    public Type type;

    public string HandTag;

    public string CosmeticName;
    public string CosmeticType;

    public Color color;

    public int buildID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(HandTag))
        {
            switch (type)
            {
                case Type.Cosmetic:
                    PhotonVRManager.SetCosmetic(CosmeticType, CosmeticName);
                    break;
                case Type.Color:
                    PhotonVRManager.SetColour(color);
                    break;
                case Type.Scene:
                    SceneManager.LoadScene(buildID);
                    break;
                default:
                    break;
            }
        }
    }
}
