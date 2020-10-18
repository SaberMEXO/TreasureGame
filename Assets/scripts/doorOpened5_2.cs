using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpened5_2 : MonoBehaviour
{
    public door5_2 Door5Opened;

    public AudioSource doorSlide;

    // Start is called before the first frame update
    void Start()
    {
        doorSlide = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Door5Opened.doorOpen5 == true)
        {
            doorSlide.Play();
            Destroy(this);
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
