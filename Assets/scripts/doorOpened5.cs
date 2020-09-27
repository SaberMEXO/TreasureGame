using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpened5 : MonoBehaviour
{
    public door5 Door5Opened;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Door5Opened.doorOpen5 == true)
        {
            Destroy(this);
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
