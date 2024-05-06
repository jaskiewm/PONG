using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public GameObject winnerText;
    public GameObject ball;
    public GameObject winCanvasUI;
    public GameObject gameManager;
    private string whoWon;

    // If True, player 1 wins, otherwise, player 2 wins
    public void gameWon(bool player1Win)
    {
        Time.timeScale = 0f;
        winCanvasUI.SetActive(true);
        if (player1Win == true)
        {
            whoWon = "Player 1 Wins!";
        }
        else
        {
            whoWon = "Player 2 Wins!";
        }
        winnerText.GetComponent<TextMeshProUGUI>().text = whoWon;
    }
    public void Rematch()
    {
        winCanvasUI.SetActive(false);
        gameManager.GetComponent<GameManager>().resetGane();
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync("Assets/Scenes/Main Scene.unity");
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("Quitting Game");
    }
}
