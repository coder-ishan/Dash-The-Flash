using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviourPunCallbacks
{
   
 public GameObject playerPrefab;
//  public GameObject playerPrefab2;
 public float minX;
 public float maxX;
 public float minY;
 public float maxY;
//  public float y;

public void Start()
{
    Vector2 randomPosition = new Vector2(Random.Range(minX,maxX), Random.Range(minY,maxY));
    // Vector3 randomPosition = new Vector3(-9.0f,-1.0f, 16.0f);
    PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    Debug.Log("mmm");

}


}
// public void newPlayer()
// {
//       Vector3 randomPosition = new Vector3(Random.Range(minX,maxX), Random.Range(minZ,maxZ));
//     PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
// }

// }
