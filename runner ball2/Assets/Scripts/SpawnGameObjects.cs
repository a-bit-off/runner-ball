using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGameObjects : MonoBehaviour
{
    public GameObject[] enemyPoint;
    private Vector3 spawnPos;



    void Start()
    {
        int n = 50;

        for (int i = 0; i < 6; i++)
        {
            spawnPos.x = Random.Range(-4, 4);
            spawnPos.y = 0.5f;
            spawnPos.z = Random.Range(n, n + 50);
            n += 50; 
            SpawnGO(spawnPos);
        }
    }



    private void SpawnGO(Vector3 spawnPos)
    {
        int i = (int)Random.Range(0, 2);
        GameObject nextGO = Instantiate(enemyPoint[i], spawnPos, transform.rotation);

    }



    public void SpawnPosition(float player)
    {
        for (int i = 0; i < 2; i++)
        {
            spawnPos.x = Random.Range(-4, 4);
            spawnPos.y = 0.5f;
            spawnPos.z = Random.Range((player + 350), (player + 450));

            SpawnGO(spawnPos);
        }
    }
}
