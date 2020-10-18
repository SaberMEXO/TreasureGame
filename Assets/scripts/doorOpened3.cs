using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpened3 : MonoBehaviour
{
    public door3 Door3Opened;

    public AudioSource doorSlide;
    // Start is called before the first frame update
    void Start()
    {
        doorSlide = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Door3Opened.doorOpen3 == true)
        {
            doorSlide.Play();
            Destroy(this);
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}