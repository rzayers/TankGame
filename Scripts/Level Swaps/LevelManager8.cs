using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelManager8 : MonoBehaviour
{
    public GameObject[] enemies;




    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)

        {


            SceneManager.LoadScene("Level 9");
        }



    }
}
