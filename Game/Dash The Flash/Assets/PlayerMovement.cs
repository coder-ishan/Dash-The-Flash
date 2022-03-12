using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{

        // private Camera myCamera;
    public CharacterController controller;


//   PhotonView view;
//    private void Start()
//    {
//        view = GetComponent<PhotonView>();
//    }

//    void Update()
//     {

//         if (view.IsMine)

            
    
//        public float currentVelocity = 10;
//        public float smoothTime = 0.3f;
//         Vector2 currentVelocity;
      
  


//         // if(direction.magnitude >= 0.1f)
        
//        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//         controller.position = Vector2.SmoothDamp(controller.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed);
        
//         }




/*

 private Camera myCamera; // Copy of the main camera, attached to the player
 
 public override void OnStartLocalPlayer()
 {
     myCamera = Instantiate(Camera.main);
     myCamera.transform.rotation = transform.rotation;
     myCamera.transform.position = transform.position + new Vector3(offsetX, offsetY, offsetZ);
     myCamera.transform.SetParent(transform);
 }
 void Update()
 {
     // Do update stuff, including moving the player
     // ...
     Camera.main.CopyFrom(myCamera);
 }

*/
    // public CharacterController controller;
    // public Transform cam;   /////



    public float speed = 6f;
    public float turnSmoothTime = 0.1f;////////

    // float turnSmoothVeclocity;///////////



    PhotonView view;
    void Start()
   {
        // Camera.main.GetComponent<Camerafollow>().setTarget(gameObject.transform);
       view = GetComponent<PhotonView>();
        if (!view.IsMine)
       {
           Destroy(GetComponentInChildren<Camera>().gameObject);
       }
     
   }




    // Update is called once per frame
    void Update()
    {    
       
                
        if (view.IsMine)
        {
              float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(horizontal,vertical).normalized;

        // transform.position += input.normalized*speed*Time.deltaTime;
        // Camera.main.CopyFrom(myCamera);
            
        
        if(direction.magnitude >= 0.1f)
        {
            // float targetAngle = Mathf.Atan2(direction.x,direction.z) * Mathf.Rad2Deg;///////////
            // float targetAngle = Mathf.Atan2(direction.x,direction.z) * Mathf.Rad2Deg+cam.eulerAngles.y;///////////



            
            // float targetAngle = Mathf.Atan2(direction.x,direction.z) * Mathf.Rad2Deg;
            
            // float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle,ref turnSmoothVeclocity,turnSmoothTime);/////
            // transform.rotation = Quaternion.Euler(0f, targetAngle,0f);////////

            // Vector3 moveDir = Quaternion.Euler(0f, targetAngle,0f)*Vector3.forward;////////////


 
            // controller.Move(moveDir.normalized * speed *Time.deltaTime);////////////////
            controller.Move(direction* speed *Time.deltaTime);
        }
         
        }
      
      
    }
}

    

