using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{


    public float speed = 5;

  
   

    void Update()
    {

        transform.Rotate(0, 0, -speed * Time.deltaTime);

    }


}
