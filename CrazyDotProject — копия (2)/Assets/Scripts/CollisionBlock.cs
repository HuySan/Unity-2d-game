using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This script allows you to play sound in contact with the object.
/// </summary>
public class CollisionBlock : MonoBehaviour {
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.relativeVelocity.magnitude > 2)
            audioSource.Play();
    }

}
