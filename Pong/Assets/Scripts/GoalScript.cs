using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isPlayer1Goal;
    public AudioSource audioSource;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Ball")){
            if (isPlayer1Goal){
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
            else{
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
            audioSource.PlayOneShot(clip, audioSource.volume);
        }
    }
}
