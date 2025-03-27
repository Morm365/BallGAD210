using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class NewJumpPush : MonoBehaviour
{

    public float jumpSpeed = 2f;

    private Rigidbody2D ball;

    public float angleBounced = 10f;





    void Start()
    {

        ball = GetComponent<Rigidbody2D>();




    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        
        Vector2 normal = collision.contacts[0].normal; 


        float angleRandomisation = Random.Range(-angleBounced, angleBounced);  //random angle generation


        // Vector2 newVelocity = normal * jumpSpeed;

        Vector2 newVelocity = Quaternion.Euler(0, 0, angleRandomisation) * normal; // spin normal to the angle

        // ball.velocity = newVelocity;

        ball.velocity = newVelocity.normalized * jumpSpeed;

    }




}
