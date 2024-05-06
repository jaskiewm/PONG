using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject Player1Text;
    public GameObject Player2Text;
    public GameObject Ball;
    public GameObject WinScreen;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored(){
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        Ball.GetComponent<BallRespawn>().ballReset();

        if (Player1Score == 11)
        {
            WinScreen.GetComponent<WinGame>().gameWon(true);
        }
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        Ball.GetComponent<BallRespawn>().ballReset();

        if (Player2Score == 11)
        {
            WinScreen.GetComponent<WinGame>().gameWon(false);
        }
    }

    public void resetGane()
    {
        Player1Score = 0;
        Player2Score = 0;
    }
}
