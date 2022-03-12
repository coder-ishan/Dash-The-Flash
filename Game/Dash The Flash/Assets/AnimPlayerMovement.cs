using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class AnimPlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Animator anim;
    private float moveSpeed;
    private bool facingFront = true;
    private Vector3 localScale;
    //  public CharacterController controller;
      public float speed = 6f;
    public float turnSmoothTime = 0.1f;
     PhotonView view;
    private void Start()
    {
    
     view = GetComponent<PhotonView>();
      if (!view.IsMine)
       {
           Destroy(GetComponentInChildren<Camera>().gameObject);
       }
    rb = GetComponent<Rigidbody>();
    anim = GetComponent<Animator>();
    localScale = transform.localScale;
    moveSpeed = 5f;

    }


    private void Update()
    {
      float horizontal= Input.GetAxisRaw("Horizontal")*moveSpeed;
      float vertical = Input.GetAxisRaw("Vertical")*moveSpeed;
       Vector2 direction = new Vector2(horizontal,vertical).normalized;


      if(rb.velocity.x ==0)
      {
      anim.SetBool("isMovingRight",false);
      anim.SetBool("isMovingLeft",false);
      }
      if(rb.velocity.y ==0)
      {
      anim.SetBool("isMovingUp",false);
      anim.SetBool("isMovingDown",false);
      }
      if (rb.velocity.x>0)
      {
          anim.SetBool("isMovingRight",true);
      }
      if (rb.velocity.x<0)
      {
          anim.SetBool("isMovingLeft",true);
      }
      if (rb.velocity.y<0)
      {
          anim.SetBool("isMovingDown",true);
      }
      if (rb.velocity.y>0)
      {
          anim.SetBool("isMovingUp",true);

      }

     void Update()
      {
        //   rb.velocity = new Vector2(rb.velocity.x,rb.velocity.y);
            

      }
     void LateUpdate()
      {
          if (direction.magnitude<0)
           facingFront = true;
           else if (direction.magnitude>0)
           facingFront = false;

           if (((facingFront)&& (localScale.x<0))|| ((!facingFront)&&(localScale.x>0)))
              localScale.x *= -1;

              transform.localScale = localScale;
      }


      



    















    }
    }















