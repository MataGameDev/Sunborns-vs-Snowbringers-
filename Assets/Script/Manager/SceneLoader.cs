using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public string nombre;
    public void cambio()
    {
        SceneManager.LoadScene(nombre);
    }
}
