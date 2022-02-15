using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 player_vector;
    [SerializeField] private int speed;
    [SerializeField] private int speedSide;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (SwipeController.swipeLeft)
            SwipeLeft();

        if (SwipeController.swipeRight)
            SwipeRight();
    }

    private void FixedUpdate()
    {
        player_vector.z = speed;
        controller.Move(player_vector * Time.fixedDeltaTime);
    }


    private void SwipeLeft()
    {
        player_vector.x = (speed * -1) / 4;
    }

    private void SwipeRight()
    {
        player_vector.x = speed / 4;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
