using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    public int points = 0;
    public int coins = 0;
    public int bpoints = 0; 
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI Coins;
    public TextMeshProUGUI bScore;

    




    public void StartGame()
    {
        Time.timeScale = 1;
      
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        
        SceneManager.LoadScene("Game");
    }
    public void OnGameOver()
    {
        ShowLoseUI();
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        points++;
        scoreText.text = points.ToString();
        bpoints = PlayerPrefs.GetInt("Save");
    }
    public void UpdateCoin()
    {
        
        coins++;
        Coins.text = coins.ToString();
        
    }
    public void BestScore()
    {
     
        if (points > bpoints)
        {
            bpoints = points;
            BestScoreSave();
            bScore.text = bpoints.ToString();
            
        }


    }
    public void BestScoreSave()
    {
        PlayerPrefs.SetInt("Save", points);
        Debug.Log(bpoints);


    }
    private void Start()
    {
        bScore.text = PlayerPrefs.GetInt("Save").ToString();
    }
}
