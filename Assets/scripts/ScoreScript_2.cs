using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript_2 : MonoBehaviour
{
    public bool winConditionFul;
    public static int scoreValue = 0;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue < 5)
        {
            score.text = "Score : " + scoreValue;
        }
        else if (scoreValue >= 5)
        {
            //score.text = "Congrats,you win!";
        }
    }
}
