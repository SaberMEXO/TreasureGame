using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public GameObject spawnPoint;

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
        if (other.CompareTag("coin"))
        {
            Destroy(other);
            other.GetComponent<Renderer>().enabled = false;
        }
        
    }
    public void PlayerDeath()
    {

        //Destroy(gameObject);
        //LevelManager.instance.Respawn();
        transform.position = spawnPoint.transform.position;
       
    }
}
