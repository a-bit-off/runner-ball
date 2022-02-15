using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGeneration : MonoBehaviour
{
    public GameObject[] grounds;
    private float spawnPos = 0;
    private float groundLength = 100;
    private int startGrounds = 5;
    private List<GameObject> activeGrounds = new List<GameObject>();

    [SerializeField] private Transform player;

    public SpawnGameObjects SGO;

    void Start()
    {
        for (int i = 0; i < startGrounds; i++)
        {
            SpawnGround(Random.Range(0, grounds.Length));
        }
    }

    void Update()
    {
        if(player.position.z - 60 > spawnPos - (startGrounds * groundLength))
        {
            SpawnGround(Random.Range(0, grounds.Length));
            DeliteGround();
            SGO.SpawnPosition(player.position.z);
        }
    }

    private void SpawnGround(int index)
    {
        GameObject nextGround = Instantiate(grounds[index], transform.forward * spawnPos, transform.rotation);
        spawnPos += groundLength;
        activeGrounds.Add(nextGround);
    }
    private void DeliteGround()
    {
        Destroy(activeGrounds[0]);
        activeGrounds.RemoveAt(0);
    }
}
