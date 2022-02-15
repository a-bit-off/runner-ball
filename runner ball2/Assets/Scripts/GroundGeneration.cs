using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGeneration : MonoBehaviour
{
    public GameObject[] grounds;
    private float spawnPos = 0;
    private float groundLength = 100;
    private int startGrounds = 5;

    [SerializeField] private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startGrounds; i++)
        {
            SpawnGround(Random.Range(0, grounds.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.z > spawnPos - (startGrounds * groundLength))
        {
            SpawnGround(Random.Range(0, grounds.Length));
        }
    }

    private void SpawnGround(int index)
    {
        Instantiate(grounds[index], transform.forward * spawnPos, transform.rotation);
        spawnPos += groundLength;
    }
}
