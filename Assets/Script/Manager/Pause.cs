using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Pause : MonoBehaviour
{
    public GameObject menu;
    public GameObject bloqueo;
    public TextMeshProUGUI Boton;
    public void Pausar()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            menu.SetActive(true);
            bloqueo.SetActive(true);
            Boton.color = Color.black;
            Boton.text = "Pause";
        }
        else
        {
            Time.timeScale = 1;
            bloqueo.SetActive(false);
            menu.SetActive(false);
        }
    }
}
