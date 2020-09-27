using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public follow_up cameraMovement;

    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            cameraMovement.inDeadZone = true;
        }
    }

    // Update is called once per frame
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            cameraMovement.inDeadZone = false;
        }
    }
}
