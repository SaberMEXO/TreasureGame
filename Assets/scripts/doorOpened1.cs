using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpened1 : MonoBehaviour
{
    public door1 Door1Opened;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Door1Opened.doorOpen1 == true)
        {
            Destroy(this);
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
