using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door3 : MonoBehaviour
{
    public bool doorOpen1 = false;
    public bool doorOpen2 = false;
    public bool doorOpen3 = false;
    public bool doorOpen4 = false;
    public bool doorOpen5 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            doorOpen3 = true;
        }
    }
}