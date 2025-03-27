using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{



    public AudioClip bounceSoun;

    private AudioSource audioSource;

    public ParticleSystem bounceParticles;

    public float particleLifetime = 0.5f;


    void Start()
    {

        audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.playOnAwake = false;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Surface") && bounceSoun != null && bounceParticles != null)
        {

            audioSource.PlayOneShot(bounceSoun);

            ContactPoint2D contact = collision.contacts[0];

            ParticleSystem particles = Instantiate(bounceParticles, contact.point, Quaternion.identity);

            particles.Play();

            Destroy(particles.gameObject, particleLifetime);
        }




    }



}
