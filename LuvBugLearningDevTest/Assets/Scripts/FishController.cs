using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    public int Speed = 10;
    public int FishNo;

    // Update is called once per frame
    void Update()
    {
        MoveFish();
    }

    public void MoveFish()
    {
        Vector3 Movement;
        Movement = new Vector3(-1, 0, 0);
        transform.position += Movement * Speed * Time.deltaTime;

    }
    public void DisableMovement()
    {
        Speed = 0;
        gameObject.GetComponent<OscillateObject>().enabled = false;
    }
}
