using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScoreBoard2 : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float scoreAmount;
    public float scoreIncreasePerSecond;
    float timer = 0f;

    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
        scoreAmount = 0f;
        scoreIncreasePerSecond = 1f;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + " Score";
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            scoreAmount += 1;
        }

    }
}