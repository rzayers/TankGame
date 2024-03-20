using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject tryAgain;
    public Turret turret;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            
            Debug.Log("HIT");

            turret.canShoot = false;
            gameObject.SetActive(false);
            tryAgain.SetActive(true);

            
        }
    }




    
}
