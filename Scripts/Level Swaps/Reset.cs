using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        Debug.Log("Clicked");
        SceneManager.LoadScene("MainMenu");
    }



}
