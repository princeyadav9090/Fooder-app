using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{

    public void UI()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Burger()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Pizza()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void Samosa()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void Coffee()
    {
        SceneManager.LoadSceneAsync(5);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex > 0)
            {
                SceneManager.LoadSceneAsync(0);
            }
            else
            {
                Application.Quit();
            }
        }
    }

}