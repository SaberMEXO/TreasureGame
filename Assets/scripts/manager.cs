using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public static int health;

    public string nextScene;

    public GameObject life1, life2, life3;

    void Start()
    {
        health = 3;
        life1.gameObject.SetActive(true);
        life2.gameObject.SetActive(true);
        life3.gameObject.SetActive(true);
    }

    void Update()
    {
        if (health >= 3)
        {
            health = 3;
            life1.gameObject.SetActive(true);
            life2.gameObject.SetActive(true);
            life3.gameObject.SetActive(true);

            //switch (health)
            //{
            //    case 3:
            //        life1.gameObject.SetActive(true);
            //        life2.gameObject.SetActive(true);
            //        life2.gameObject.SetActive(true);
            //        break;
            //    case 2:
            //        life1.gameObject.SetActive(true);
            //        life2.gameObject.SetActive(true);
            //        life2.gameObject.SetActive(false);
            //        break;
            //    case 1:
            //        life1.gameObject.SetActive(true);
            //        life2.gameObject.SetActive(false);
            //        life2.gameObject.SetActive(false);
            //        break;
            //    case 0:
            //        life1.gameObject.SetActive(false);
            //        life2.gameObject.SetActive(false);
            //        life2.gameObject.SetActive(false);
            //        break;
            //}
        }
        else if(health == 2)
        {
            life1.gameObject.SetActive(true);
            life2.gameObject.SetActive(true);
            life3.gameObject.SetActive(false);
        }
        else if(health == 1)
        {
            life1.gameObject.SetActive(true);
            life2.gameObject.SetActive(false);
            life3.gameObject.SetActive(false);
        }
        else if(health == 0)
        {
            life1.gameObject.SetActive(false);
            life2.gameObject.SetActive(false);
            life3.gameObject.SetActive(false);
            SceneManager.LoadScene(nextScene);
        }
    }
}
