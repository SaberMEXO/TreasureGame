using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string nextScene;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && ScoreScript.scoreValue >= 4)
        {
            //print("nextScene");
            SceneManager.LoadScene(nextScene);
        }
    }
}
