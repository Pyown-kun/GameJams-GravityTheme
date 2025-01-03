using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] itemPrefeb;

    [SerializeField] private float minstartSpawnTime;
    [SerializeField] private float maxstartSpawnTime;
    [SerializeField] private float minSpawnTime;
    [SerializeField] private float maxSpawnTime;

    private float spawnTime;
    private float randomSpawn;

    private void Awake()
    {
        float startSpawnTime = Random.Range(minstartSpawnTime, maxstartSpawnTime);
        spawnTime = startSpawnTime;
        SetRandomSpawn();
    }

    private void Update()
    {
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            if (randomSpawn <= 2)
            {
                SetSpawn(0);
            }
            else if (randomSpawn <= 3)
            {
                SetSpawn(1);
            }
            else if (randomSpawn <= 4)
            {
                SetSpawn(2);
            }
            else if (randomSpawn <= 5)
            {
                SetSpawn(3);
            }
            SetSpawnTime();
        }
    }

    private void SetSpawn(int number)
    {
        Instantiate(itemPrefeb[number], transform.position , Quaternion.identity);
        SetRandomSpawn();
    }

    private void SetRandomSpawn()
    {
        randomSpawn = Random.Range(1, 6);
    }

    private void SetSpawnTime()
    {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
