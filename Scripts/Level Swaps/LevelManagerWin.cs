using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelManagerWin : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject win;




    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)

        {


            win.SetActive(true);
        }



    }
}
