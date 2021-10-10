using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] ScoreController scoreController;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            scoreController.Score += 1;
            scoreController.ScoreText.text = "Score : " + scoreController.Score;
        }
    }
}
