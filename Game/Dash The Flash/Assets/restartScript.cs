using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class restartScript : MonoBehaviour
{
    public void OnClickRestart()
    {
         PhotonNetwork.LoadLevel("loading");
    }
}
