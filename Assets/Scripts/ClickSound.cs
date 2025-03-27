using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{

    public AudioClip soundClip;
    private AudioSource audioSource;




    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {


            audioSource = gameObject.AddComponent<AudioSource>();

        }

    }

    
    void OnMouseDown()
    {

        audioSource.PlayOneShot(soundClip);


    }
}
