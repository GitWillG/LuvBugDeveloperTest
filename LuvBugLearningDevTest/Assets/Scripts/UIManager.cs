
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Transform TargetSpawnPoint;
    public TextMeshProUGUI ScorePoints;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        //ChangeTargetFish()
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
