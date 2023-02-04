using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillateObject : MonoBehaviour
{
    public float amplitude = 1.0f;
    public float frequency = 1.0f;
    private float startY;
    private float randomFloat;

    void Start()
    {
        startY = transform.position.y;
        randomFloat = Random.Range(0f, 10f);
    }

    void Update()
    {
        float y = amplitude * Mathf.Sin((Time.time + randomFloat) * frequency);
        transform.position = new Vector3(transform.position.x, startY + y, transform.position.z);
    }
}
