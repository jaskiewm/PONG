using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundEffects : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip clip;

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Player")){
            audioSource.PlayOneShot(clip, audioSource.volume);
        }
    }
}
