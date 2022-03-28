using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    private GameObject newHealth;
    private SpriteRenderer rend;
    private int randomSpawnZone;
    private float randomXposition, randomYposition;
    private Vector3 spawnPosition;

    void Start()
    {
        InvokeRepeating("SpawnNewHealth", 0f, 2f);
    }

    // Update is called once per frame
    private void SpawnNewHealth()
    {
        randomSpawnZone = Random.Range(0, 4);
        switch (randomSpawnZone)
        {
            case 0:
                randomXposition = Random.Range(-11f, -10f);
                randomYposition = Random.Range(-8f, -8f);
                break;
            case 1:
                randomXposition = Random.Range(-11f, 10f);
                randomYposition = Random.Range(-7f, -8f);
                break;
            case 2:
                randomXposition = Random.Range(10f, 11f);
                randomYposition = Random.Range(-8f, 8f);
                break;
            case 3:
                randomXposition = Random.Range(-10f, 10f);
                randomYposition = Random.Range(7f, 8f);
                break;

        }

        spawnPosition = new Vector3(randomXposition, randomYposition, 0f);
        newHealth = Instantiate(newHealth, spawnPosition, Quaternion.identity);
        rend = newHealth.GetComponent<SpriteRenderer>();
        rend.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
    }
}
