using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void cambio(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void exit()
    {
        Application.Quit();
    }
}
