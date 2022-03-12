using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;


public class Weapon : MonoBehaviour
{   
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
        
    // PhotonView view;
    void Start()
    {
        //  view = GetComponent<PhotonView>();
    }
    void Update(){
   
    //    if (view.IsMine)
       {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
       }

    
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    }
}