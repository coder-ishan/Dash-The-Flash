using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;


    void Start()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement*moveSpeed * Time.fixedDeltaTime);
    }
}
