using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource ad;

    // Start is called before the first frame update
    void Start()
    {
        ad.volume = PlayerPrefs.GetFloat("volume");
    }

}
