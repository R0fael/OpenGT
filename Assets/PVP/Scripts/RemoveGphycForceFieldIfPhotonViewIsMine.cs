using OpenGT.Gphyc;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class RemoveGphycForceFieldIfPhotonViewIsMine : MonoBehaviour
{
    public PhotonView view;

    private void Awake()
    {
        if(view.IsMine)
        {
            Destroy(GetComponent<ForceField>());
        }
    }
}
