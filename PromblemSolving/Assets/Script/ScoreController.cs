using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text ScoreText;
    public int Score;
    Enemy enemy; 

    void Start()
    {
        Score = 0;
        ScoreText.text = "Score : " + Score;

        enemy = GetComponent<Enemy>();
    }
}
