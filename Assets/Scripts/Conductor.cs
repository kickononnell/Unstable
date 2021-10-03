using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    public GameObject[] prefabs;
    public Canvas canvas;
    public float spawnInterval;
    private float spawnTimer;

    void Start()
    {
        spawnTimer = 0;
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0;
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], canvas.pixelRect.center, Quaternion.identity, canvas.transform);
        }
    }
}
