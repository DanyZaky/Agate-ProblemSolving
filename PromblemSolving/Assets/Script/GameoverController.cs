using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverController : MonoBehaviour
{
    [SerializeField] ScoreController scoreControll;
    [SerializeField] MoveInputTouch moveTouch;
    [SerializeField] SpawnerEnemy spawnerEnemy;

    public GameObject gameoverPanel;
    float currentTime = 0f;

    bool timing;

    [SerializeField] Text TimeText, scoreResult;

    void Start()
    {
        currentTime = spawnerEnemy.numberToSpawn * 2;
        timing = true;
    }

    void Update()
    {
        if (timing == true)
        {
            currentTime -= 1 * Time.deltaTime;            
        }
        TimeText.text = "Time Left : " + (currentTime.ToString("0"));

        if (currentTime < 0)
        {
            timing = false;
            gameoverPanel.SetActive(true);

            scoreResult.text = "Your Score : " + scoreControll.Score;

            moveTouch.gameOver = true;

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        
    }
}
