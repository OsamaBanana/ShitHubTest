using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void Update()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
    }

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = score.ToString() + " Score";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }
}

    