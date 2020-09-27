using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpened4 : MonoBehaviour
{
    public door4 Door4Opened;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Door4Opened.doorOpen4 == true)
        {
            Destroy(this);
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
