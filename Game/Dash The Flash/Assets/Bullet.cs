using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{ 

public float speed = 20f;
public Rigidbody2D rb;
  PhotonView view;








    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right*speed;

    }
    void OnTriggerEnter2D (Collider2D hitinfo)
    {
        Debug.Log(hitinfo.name);
        // Destroy(gameObject);
    }

   
}
