
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Transform TargetSpawnPoint;
    public TextMeshProUGUI ScorePoints;
    public int Score;
    public float TimeRemaining;
    public TextMeshProUGUI Timer;
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = 300;
        Score = 0;
        //ChangeTargetFish()
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }
    //public void ChangeTargetFish(GameObject newFish)
    //{
    //    TargetFish = Instantiate(newFish, TargetSpawnPoint);
    //}
    public void UpdateScore()
    {
        Score += 10;
        ScorePoints.text = Score.ToString();
    }
    public void UpdateTime()
    {
        TimeRemaining -= Time.deltaTime;
        int timeInt = Mathf.RoundToInt(TimeRemaining);
        Timer.text = timeInt.ToString() + " Seconds";

    }
    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
