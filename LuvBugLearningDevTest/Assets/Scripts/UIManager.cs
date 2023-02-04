
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
    public TextMeshProUGUI winningPoints;
    public int Score;
    public float TimeRemaining;
    public TextMeshProUGUI Timer;
    public GameObject GameOverPanel;
    public GameObject GameWinPanel;
    // Start is called before the first frame update
    void Start()
    {
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
        Score += 1;
        ScorePoints.text = Score.ToString();
    }
    public void UpdateTime()
    {
        TimeRemaining -= Time.deltaTime;
        int timeInt = Mathf.RoundToInt(TimeRemaining);
        Timer.text = timeInt.ToString() + " Seconds";
        if (TimeRemaining <=0)
        {
            GameWinPanel.SetActive(true);
            winningPoints.text = Score.ToString() + " fish, yummy!";
            Time.timeScale = 0;
        }

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
