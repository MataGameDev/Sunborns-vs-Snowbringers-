using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause : MonoBehaviour
{
    public GameObject menu;
    public GameObject bloqueo;
    public void Pausar()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            menu.SetActive(true);
            bloqueo.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            bloqueo.SetActive(false);
            menu.SetActive(false);
        }
    }
}
