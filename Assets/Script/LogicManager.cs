using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    private int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSFX;


    [ContextMenu("Increase Score")]


    public void add(int score)
    {
        playerScore = playerScore + score;
        scoreText.text = playerScore.ToString();
        scoreSFX.Play();
    }

    public void gameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        
    }
}