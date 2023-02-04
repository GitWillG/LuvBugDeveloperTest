using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkController : MonoBehaviour
{
    public int Speed = 10;
    public GameObject Shark;
    public GameObject TargetFishHolder;
    public int TargetNo;
    public UIManager _UIManager;
    public FishManager _FishManager;


    // Start is called before the first frame update
    void Start()
    {
        Shark = this.gameObject;
        GetNewTarget();
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
    }

    public void getInput()
    {
        Vector3 Movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0 );
        Shark.transform.position += Movement*Speed*Time.deltaTime;
    }
    public void GetNewTarget()
    {
        TargetNo = TargetFishHolder.transform.GetChild(0).GetComponent<FishController>().FishNo;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fish"))
        {
            FishController ConsumedFish = other.GetComponent<FishController>();
            if (ConsumedFish.FishNo == TargetNo)
            {
                _FishManager.ChangeTarget();
                _UIManager.UpdateScore();
                Invoke(nameof(GetNewTarget), 0.1f);
            }
            else
            {
                _UIManager.GameOver();
            }
            Destroy(other.gameObject);
        }
    }
}
