using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_up : MonoBehaviour
{
    public Transform characterPlayer;

    public float smoothTime = 0.1f;

    public bool inDeadZone;

    public float maxTime;
    public float currentTime;

    Vector3 thisVelocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (inDeadZone == false)
        {
            currentTime = maxTime;
        }
        if (inDeadZone == true)
        {
            if (currentTime <= 0) return;

            currentTime -= Time.deltaTime;
        }

        Vector3 targetPosition = characterPlayer.TransformPoint(new Vector3(0, 0, -10f));

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref thisVelocity, smoothTime);
    }
}
