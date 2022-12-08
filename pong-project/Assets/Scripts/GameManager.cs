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

    public void OneScores()
    {
        _oneScore++;
        oneScore.text = _oneScore.ToString();
       

        this.ball.ResetPosition();
    }

    public void TwoScores()
    {
        _twoScore++;
       
        twoScore.text = _twoScore.ToString();

        this.ball.ResetPosition();

    }


}
