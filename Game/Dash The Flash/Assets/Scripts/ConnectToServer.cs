using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
   // public InputField usernameInput;
   // public Text buttonText;

    private void Start()
    {
       PhotonNetwork.ConnectUsingSettings();
    }



   //  public void OnClickConnect()
   // {
   //    //  if (usernameInput.text.Length >= 1)
   //    //  {
   //    //      PhotonNetwork.Nickname = usernameInput.text;
   //    //      buttonText.text = "Connecting...";
   //    //      PhotonNetwork.ConnectUsingSettings();

   //    //  }
   //     PhotonNetwork.ConnectUsingSettings();
   // }
  
//   void ConnectToPhotonNetwork() {
//     PhotonNetwork.AddCallbackTarget(this);
//     PhotonNetwork.GameVersion = "1.0.0";
//     PhotonNetwork.ConnectUsingSettings();
// }

//     PhotonNetwork.CreateRoom(serverName, new RoomOptions)
//      {
//     MaxPlayers = 5;
// }





   public override void OnConnectedToMaster()
   {
      PhotonNetwork.JoinLobby();
      Debug.Log("Connected to master");
      // SceneManager.LoadScene("lobby");

   }
  public override void OnJoinedLobby()
  {
     SceneManager.LoadScene("lobby");
     Debug.Log("Joined lobby");

  }

}
