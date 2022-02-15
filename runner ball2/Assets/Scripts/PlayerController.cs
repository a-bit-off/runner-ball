using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public EnemyAndPoint EAP;
    private Vector3 player_vector;
    [SerializeField] public float speed;
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
        player_vector.x = -speedSide;
    }

    private void SwipeRight()
    {
        player_vector.x = speedSide;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        EAP.FindTag(other);
    }

}
