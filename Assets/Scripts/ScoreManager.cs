using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Debug.Log("ScoreManager instance created");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "Pontos: " + score;
        Debug.Log("Pontuação: " + score);
    }

    public int GetScore()
    {
        return score;
    }
}
