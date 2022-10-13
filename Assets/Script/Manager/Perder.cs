using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Perder : MonoBehaviour
{
    public GameObject menu;
    public GameObject pausar;
    public GameObject bloqueo;
    public TextMeshProUGUI Boton;
    private void OnTriggerEnter2D(Collider2D _other)
    {
        if (_other.tag == "Nieve")
        {
            Time.timeScale = 0;
            menu.SetActive(true);
            pausar.SetActive(false);
            Boton.color = Color.red;
            bloqueo.SetActive(true);
            Boton.text = "Perdiste";
        }
    }
}
