using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    public GameObject bloqueo;
    public int enemysLevel;
    public int levelID;
    public Data data;

    // Update is called once per frame


    public void Ganar(int enemigosCantidad)
    {
        if (enemigosCantidad == enemysLevel)
        {
            Time.timeScale = 0;
            menu.SetActive(true);
            bloqueo.SetActive(true);
            data.levelsCompleted[levelID] = true;
        }
    }
 
}
