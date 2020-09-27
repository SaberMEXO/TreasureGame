using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpened2 : MonoBehaviour
{
    public door2 Door2Opened;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Door2Opened.doorOpen2 == true)
        {
            Destroy(this);
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
