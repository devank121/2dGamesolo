using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text heartsText;
    public int score;
    public int hearts = 5;
    public GameObject gameOverPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: "+score;
    }

    public void LoseHeart()
    {
        hearts -= 1;
        heartsText.text = "Hearts: " + hearts;
        if (hearts < 1)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void RestartGame()
    {
        score = 0;
        hearts = 5;
        scoreText.text = "Score: " + score;
        heartsText.text = "Hearts: " + hearts;
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }

}
