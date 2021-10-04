using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    public GameObject[] prefabs;
    public AudioClip[] clips;
    public Canvas canvas;
    public float spawnInterval;
    public AudioSource audioSource;

    private float spawnTimer;

    void Start()
    {
        spawnTimer = 0f;
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0f;
            if (spawnInterval > 0.5f)
            {
                spawnInterval -= 0.1f;
            }

            int objectId = Random.Range(0, prefabs.Length);

            GameObject spawnObject = prefabs[objectId];
            RectTransform rectTransform = spawnObject.GetComponent<RectTransform>();
            Instantiate(spawnObject, new Vector2(Random.Range(rectTransform.rect.width * 1.5f, canvas.pixelRect.width - rectTransform.rect.width * 1.5f), Random.Range(rectTransform.rect.height * 1.5f, canvas.pixelRect.height - rectTransform.rect.height * 1.5f)), Quaternion.identity, canvas.transform);

            audioSource.PlayOneShot(clips[objectId]);
        }
    }

}
