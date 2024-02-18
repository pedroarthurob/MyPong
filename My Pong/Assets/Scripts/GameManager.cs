using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball ball;
    [SerializeField] private int player1Score;
    [SerializeField] private int players2Score;
    [SerializeField] private TMP_Text player1ScoreText;
    [SerializeField] private TMP_Text player2ScoreText;

    private void Start()
    {
        atualizaScore();
    }
    public void Player1Score()
    {
        player1Score++;
        atualizaScore();
        ball.ResetPosition();
    }

    public void Player2Score()
    {
        players2Score++;
        atualizaScore();
        ball.ResetPosition();
    }

    private void atualizaScore()
    {
        player1ScoreText.text = player1Score.ToString();
        player2ScoreText.text = players2Score.ToString();
        
    }


 }
