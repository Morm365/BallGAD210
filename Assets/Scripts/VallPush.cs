using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VallPush : MonoBehaviour
{

    public float jumpBack = 2f;

    //public float angleSides = 45f;   //angl variations

    private Rigidbody2D ball;



    void Start()
    {

        ball = GetComponent<Rigidbody2D>();

    }

    

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Surface"))
        {

           // if (ball.velocity.magnitude == 0) return;

            //Vector2 normal = collision.contacts[0].normal; // normal of surface

            //Vector2 reflected = Vector2.Reflect(ball.velocity, normal).normalized; // reflected vector

            //float randomAngle = Random.Range(-angleSides, angleSides);   //random angle

            //Vector2 bounceDirectionFromWall = Quaternion.AngleAxis(randomAngle, Vector3.forward) * reflected;  //rotate vector

            //ball.velocity = bounceDirectionFromWall * jumpBack; // new speed

             Vector2 randomDirection = Random.insideUnitCircle.normalized;

             ball.velocity = randomDirection * jumpBack;







        }

    }
}
