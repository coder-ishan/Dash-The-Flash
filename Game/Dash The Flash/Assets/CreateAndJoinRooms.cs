using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    
 public InputField CreateText;
 public InputField JoinText;
 public InputField Username;

 public void CreateRoom()
 {
     PhotonNetwork.CreateRoom(CreateText.text);
     
 }
 public void JoinRoom()
 {
     PhotonNetwork.JoinRoom(JoinText.text);

 }
 public override void OnJoinedRoom()
 {   
    
     PhotonNetwork.LoadLevel("Game");
    

    // Vector3 randomPosition = new Vector3(Random.Range(minX,maxX), Random.Range(minZ,maxZ));
    // PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    // Debug.Log("mmm");

     //SceneManager.LoadScene("Game");
     
 }









}
