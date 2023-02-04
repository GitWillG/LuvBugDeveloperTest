using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    public GameObject[] AllFish;
    public GameObject _spawnedFish;
    public Transform[] SpawnLocations;
    public Transform TargetLocation;
    // Start is called before the first frame update
    private void Awake()
    {
        AllFish = Resources.LoadAll("FishPrefabs", typeof(GameObject)).Cast<GameObject>().ToArray();
        SpawnLocations = new Transform[4];
        for (int i = 0; i <transform.childCount; i++)
        {
            SpawnLocations[i] = transform.GetChild(i);
        }
    }
    void Start()
    {

        StartCoroutine(SpawnOnDelay(0.5f));

    }

    public void InitializeFish(GameObject fish, Transform SpawnLocation, bool Stationary)
    {
        GameObject _newFish = Instantiate(fish, SpawnLocation);
        FishController _newController = _newFish.GetComponent<FishController>();
        if (Stationary)
        {
            _newController.DisableMovement();
        }
    }

    [ContextMenu("Decide Fish")]
    public void DecideFish()
    {
        int SpecificFish = Random.Range(0, AllFish.Length);
        int LocationNo = Random.Range(0, SpawnLocations.Length);
        float RandomDelay = Random.Range(0.5f, 2f);
        InitializeFish(AllFish[SpecificFish], SpawnLocations[LocationNo], false);
        StartCoroutine(SpawnOnDelay(RandomDelay));

    }
    public IEnumerator SpawnOnDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        DecideFish();
    }
    public void ChangeTarget()
    {
        Destroy(TargetLocation.GetChild(0).gameObject);
        int SpecificFish = Random.Range(0, AllFish.Length);
        InitializeFish(AllFish[SpecificFish], TargetLocation, true);
    }
}
