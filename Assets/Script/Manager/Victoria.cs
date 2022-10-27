using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    public GameObject bloqueo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            
            Time.timeScale = 0;
            menu.SetActive(true);
            bloqueo.SetActive(true);
        }
    }
}
