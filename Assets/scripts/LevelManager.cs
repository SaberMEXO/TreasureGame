using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
   

    public static LevelManager instance;

    public Transform respawnPoint;
    public GameObject player;


    private void Awake()
    {
        instance = this;
    }

    public void Respawn()
    {
        Instantiate(player, respawnPoint.position, Quaternion.identity);
    }

    public static Vector3 GetVectorFromAngle(float angle)
    {
        float angleRad = angle * (Mathf.PI / 180f);
        return new Vector3(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
    }

}
