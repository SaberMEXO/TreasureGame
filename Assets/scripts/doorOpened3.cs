using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpened3 : MonoBehaviour
{
    public door3 Door3Opened;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Door3Opened.doorOpen3 == true)
        {
            Destroy(this);
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}