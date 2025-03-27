using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jump = 3f;

    private Rigidbody2D rigidbody;


    void Start()
    {

        rigidbody = GetComponent<Rigidbody2D>();


    }

    
    void OnMouseDown()
    {

        rigidbody.velocity = new Vector2(rigidbody.velocity.x, jump);

    }

}
