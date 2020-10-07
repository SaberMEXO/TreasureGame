using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastWallCheck : MonoBehaviour
{
    public float maxDistance = 2f;
    public float enemySpeed = 4f;

    public LayerMask rayCastLayers;

    SpriteRenderer thisSprite;

    // Start is called before the first frame update
    void Start()
    {
        thisSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //define the ray
        Ray2D myRay = new Ray2D(transform.position, transform.up);

        RaycastHit2D hit2D = Physics2D.Raycast(myRay.origin, myRay.direction, maxDistance, rayCastLayers);
        //draw the ray
        Debug.DrawRay(myRay.origin, myRay.direction * maxDistance, Color.white);

        if(hit2D.collider != null && hit2D.collider.gameObject.CompareTag("item"))
        {
            int randomNumber = Random.Range(0, 100);
            print("Hit");
            if (randomNumber < 50)
            {
                print("<50");
                transform.Rotate(new Vector3(0, 0, 90));
            }
            if (randomNumber > 50)
            {
                print(">50");
                transform.Rotate(new Vector3(0, 0, -90));
            }
        }
        if (hit2D.collider != null && hit2D.collider.gameObject.CompareTag("Player"))
        {
            hit2D.collider.gameObject.GetComponent<playerCollision>().PlayerDeath();
        }

        else
        {
            print("not hit"); 
            transform.Translate(0, Time.deltaTime * enemySpeed, 0);
        }
    }
}
