using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    private float score;
    private float highScore;
    public bool isGameOver = false;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    private void Start()
    {
        print("Logic Test");
        scoreText.text = "Score: " + score.ToString("F0");
    }

    // Update is called once per frame
    private void Update()
    {
        scoreText.text = "Score: " + score.ToString("F0");
    }

    private void OnEnable()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreText.text = "Highscore: " + PlayerPrefs.GetFloat("HighScore").ToString("F0");
        }
        else
        {
            highScoreText.text = "";
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void FixedUpdate()
    {
        if(!isGameOver)
            ConstantScoreIncrement(10);
    }


    public void IncrementScore(int value)
    {
        score += value;
    }

    private void ConstantScoreIncrement(int value)
    {
        score += Time.deltaTime * value;
    }

    public void OnGameOver()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);
        SavePrefs();
    }

    private void SavePrefs()
    {
        // Set player prefs of HighScore with playerscore
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetFloat("HighScore");
            if (highScore < score)
            {
                PlayerPrefs.SetFloat("HighScore", score);
            }
        }
        else
        {
            PlayerPrefs.SetFloat("HighScore", score);
        }
    }
}