using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    
    public int score;
    public Text scoreText;
    
    public DestroyEnemy destoryEnemy;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destoryEnemy.death)
        {
            score += 1;
            scoreText.text = "Your Score" + score;
        }
    }
}
