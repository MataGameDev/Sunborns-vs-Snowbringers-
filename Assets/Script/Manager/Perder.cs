using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perder : MonoBehaviour
{
    public GameObject menu;
    public GameObject pausar;
    public GameObject bloqueo;
    private void OnTriggerEnter2D(Collider2D _other)
    {
        if (_other.tag == "Nieve")
        {
            Time.timeScale = 0;
            menu.SetActive(true);
            pausar.SetActive(false);
            bloqueo.SetActive(true);
        }
    }
}
