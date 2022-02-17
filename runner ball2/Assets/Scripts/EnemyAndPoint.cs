using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyAndPoint : MonoBehaviour
{
    public ScenesManager SM;
    public PlayerController pController;
    [SerializeField] public Text scoreText;
    [SerializeField] public Text livesText;

    [SerializeField] private int score = 0;
    [SerializeField] private int lives = 3;

    void Start()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }


    public void FindTag(Collider other)
    {
        if (other.tag == "Point" || other.tag == "Enemy")
            Destroy(other.gameObject);
        if (other.tag == "Enemy" || other.tag == "Wall") 
        {
            lives -= 1;
            livesText.text = "Lives: " + lives;
            if (lives < 1)
                SM.Restart();
            
        }
        
        else if (other.tag == "Point")
        {
            PointManager();
        }
    }

    private void PointManager()
    {
        score += 1;
        scoreText.text = "Score: " + score;

        if (score >= 10 && score < 25)
        {
            //1.5x speed
            pController.speed *= 1.5f;

        }
        else if (score >= 25 && score < 50)
        {
            //2x speed
            pController.speed *= 2;
        }
        else if (score >= 50 && score < 100)
        {
            //3x speed
            pController.speed *= 3;
        }
        else if (score >= 100)
        {
            //4x speed
            pController.speed *= 4;
        }
    }

}
