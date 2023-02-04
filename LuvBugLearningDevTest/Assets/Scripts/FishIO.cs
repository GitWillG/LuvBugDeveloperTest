using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CreateFish", menuName = "Assets/Create/CreateFish", order = 1)]
public class FishIO : ScriptableObject
{
    [SerializeField] private string fishName;
    [SerializeField] private int speed;
    [SerializeField] private bool goRight;
    [SerializeField] private Sprite visual;
    [SerializeField] private GameObject fishPrefab;


    public string FishName => fishName;
    public int Speed => speed; 
    public bool GoRight => goRight;
    public Sprite Visual => visual;
    public GameObject FishPrefab => fishPrefab;
}
