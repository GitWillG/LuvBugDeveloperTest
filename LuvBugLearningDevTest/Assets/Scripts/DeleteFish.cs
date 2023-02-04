using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteFish : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fish"))
        {
            Destroy(other.gameObject);
        }
    }
}
