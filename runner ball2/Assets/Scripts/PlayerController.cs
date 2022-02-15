using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 player_vector;
    [SerializeField] private int speed;


    void Start()
    {
        controller = GetComponent<CharacterController>();

    }
    private void Update()
    {
        if (SwipeController.swipeLeft)
        {
            player_vector.x = (speed * -1);
            controller.Move(player_vector * Time.fixedDeltaTime);
        }
        if (SwipeController.swipeRight)
        {
            player_vector.x = speed;
            controller.Move(player_vector * Time.fixedDeltaTime);
        }
    }

    private void FixedUpdate()
    {
        player_vector.z = speed;
        controller.Move(player_vector * Time.fixedDeltaTime);
    }
   
}
