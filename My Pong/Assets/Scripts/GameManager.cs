using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball ball;
    [SerializeField] private int player1Score;
    [SerializeField] private int players2Score;
    [SerializeField] private TMP_Text player1ScoreText;
    [SerializeField] private TMP_Text player2ScoreText;
    [SerializeField] private float startDelay = 2f;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private AudioClip victoryAudio;
    [SerializeField] private TMP_Text victoryText;

    private void Start()
    {   
        atualizaScore();
        StartCoroutine(startBallMovWithDelay());
        gameOverPanel.SetActive(false);
        player1Score = 0;
        players2Score = 0;
    }

    IEnumerator startBallMovWithDelay()
    {
        yield return new WaitForSeconds(startDelay);
        ball.ResetPosition();
    }

    public void Player1Score()
    {
        player1Score++;
        atualizaScore();
        if (checkScores() != null)
        {
            GameOver();
        }
        ball.ResetPosition();
 
    }

    public void Player2Score()
    {
        players2Score++;
        atualizaScore();
        if (checkScores() != null)
        {
            GameOver();
        }
        ball.ResetPosition();
    }

    private void atualizaScore()
    {
        player1ScoreText.text = player1Score.ToString();
        player2ScoreText.text = players2Score.ToString();
        
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
        gameOverPanel.GetComponentInChildren<TMP_Text>().text = checkScores();
        SoundFXManager.instance.PlaySoundFxClip(victoryAudio, transform, 1f);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }

    private string checkScores()
    {
        string answer = null;
        if (player1Score < 9 || players2Score < 9)
        {
            if (player1Score == 11)
            {
                answer = "Player 1 Wins";
            }else if (players2Score == 11)
            {
                answer = "Player 2 Wins";
            }
        } else
        {
            if (Mathf.Abs(player1Score - players2Score) == 2)
            {
                if (player1Score > players2Score)
                {
                    answer = "Player 1 Wins";
                } else {
                    answer = "Player 2 Wins";
                }
            }
        }

        return answer;
    }
 }
