using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    private int _oneScore;

    private int _twoScore;

    public Text oneScore;

    public Text twoScore;

    public GameObject endScreen;

//public GameObject playAgainBttn;

    public Text winnerText;

    public void Awake()
    {
        Application.targetFrameRate = 60;
        endScreen.SetActive(false);
        winnerText.gameObject.SetActive(false);
      //  playAgainBttn.SetActive(false);
    }

    public void OneScores()
    {
        _oneScore++;
        oneScore.text = _oneScore.ToString();
       

        this.ball.ResetPosition();

        if (_oneScore == 10)
        {
            GameEnd();
        }
    }

    public void TwoScores()
    {
        _twoScore++;
       
        twoScore.text = _twoScore.ToString();

        this.ball.ResetPosition();

        if (_twoScore == 10)
        {
            GameEnd();
        }

    }


    public void GameEnd()
    {
        Time.timeScale = 0f;
        endScreen.SetActive(true);
        winnerText.gameObject.SetActive(true);
    //    playAgainBttn.SetActive(true);

        if (_oneScore == 10)
        {
            winnerText.text = "Player 1";
        }
        else if (_twoScore == 10)
        {
            winnerText.text = "Player 2";
        }
    }


}
