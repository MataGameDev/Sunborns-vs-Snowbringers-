using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Plantas : MonoBehaviour
{
    public int precio;
    public int vida;
    public float coldownd;
    private void OnTriggerEnter2D(Collider2D _other)
    {
        StartCoroutine("Morder");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        StopCoroutine("Morder");
    }

    private IEnumerator Morder()
    {
        while (true)
        {   
            yield return new WaitForSeconds(1.0f);
            vida -= 10;
            if (vida <= 0)
                Destroy(gameObject);
        }
    }
   
}
