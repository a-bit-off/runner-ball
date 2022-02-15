using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 offcet;

    void Start()
    {
        offcet = transform.position - player.position;
    }

    private void FixedUpdate()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, offcet.z + player.position.z);
        transform.position = newPosition;
    } 
}
