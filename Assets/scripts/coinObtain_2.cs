using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinObtain_2 : MonoBehaviour
{
    public AudioSource coin;

    // Start is called before the first frame update
    void Start()
    {
        coin = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //print("score+1");
            ScoreScript_2.scoreValue++;
            coin.Play();
        }
    }
}
