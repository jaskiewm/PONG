using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public AudioSource menuMusic;
    public Slider volumeSlider;

    public void PlayGame(){
        SceneManager.LoadSceneAsync("Assets/Scenes/Main Scene.unity");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void SetVolume(){
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        menuMusic.volume = PlayerPrefs.GetFloat("volume");
    }
}
