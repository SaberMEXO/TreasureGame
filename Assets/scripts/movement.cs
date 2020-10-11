using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1f;

    public Animator moveIdelTrans;

    Vector2 movementDir;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveIdelTrans.SetFloat("speed", -1);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
            //moveIdelTrans.SetTrigger("WASDpressed");
            moveIdelTrans.SetFloat("vertical", 1);
            moveIdelTrans.SetFloat("horizontal", 0);
            moveIdelTrans.SetFloat("speed", 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            //moveIdelTrans.SetTrigger("WASDpressed");
            moveIdelTrans.SetFloat("horizontal", -1);
            moveIdelTrans.SetFloat("vertical", 0);
            moveIdelTrans.SetFloat("speed", 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            //moveIdelTrans.SetTrigger("WASDpressed");
            moveIdelTrans.SetFloat("vertical", -1);
            moveIdelTrans.SetFloat("horizontal", 0);
            moveIdelTrans.SetFloat("speed", 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            //smoveIdelTrans.SetTrigger("WASDpressed");
            moveIdelTrans.SetFloat("horizontal", 1);
            moveIdelTrans.SetFloat("vertical", 0);
            moveIdelTrans.SetFloat("speed", 1);
        }
    }
}
