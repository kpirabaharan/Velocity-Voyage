using UnityEngine;
using TMPro;


public class LogicScript : MonoBehaviour
{
    private float score;
    public bool isGameOver = false;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    private void Start()
    {
        scoreText.text = "Score: " + score.ToString("F0");
    }

    private void FixedUpdate()
    {
        if(!isGameOver)
            IncrementScore();
    }

    // Update is called once per frame
    private void Update()
    {
        scoreText.text = "Score: " + score.ToString("F0");
        if (isGameOver)
            OnGameOver();
    }

    private void IncrementScore()
    {
        score += Time.deltaTime * 10;
    }

    public void SetIsGameOver()
    {
        isGameOver = true;
    }

    private void OnGameOver()
    {
        gameOverScreen.SetActive(true);
    }
}