using UnityEngine;
using UnityEngine.UI;  

[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    public Player player;
    private int score;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }


    public void Pause()
    {
        Time.timeScale = 0;
        player.enabled = false;
    }

    public void play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        player.enabled = true;

        Time.timeScale = 1f;

        Pipes[] pipes = Object.FindObjectsOfType<Pipes>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject); 
        }
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
