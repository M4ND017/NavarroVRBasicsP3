using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public AudioClip bounceSound;
    private AudioSource ballAudio;
    private Rigidbody ballRb;

    void Start()
    {
        ballAudio = GetComponent<AudioSource>();
        ballRb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Bonus: Calculate volume based on impact speed
        // We use the magnitude of the velocity at the moment of impact
        float impactVelocity = ballRb.velocity.magnitude;
        float volume = Mathf.Clamp01(impactVelocity / 10f);

        // Play the sound once at the calculated volume
        ballAudio.PlayOneShot(bounceSound, volume);
    }
}