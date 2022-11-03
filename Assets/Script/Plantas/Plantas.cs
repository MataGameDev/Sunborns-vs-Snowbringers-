using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantas : MonoBehaviour
{
    public int precio;
    public int vida;
    public float coldownd;

    private void OnTriggerEnter2D(Collider2D _other)
    {
        if(_other.tag == "Nieve" ){
            StartCoroutine("Morder");
        }

        if (_other.tag == "CrioExplosion")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Nieve")
        {
            StopCoroutine("Morder");
        }
    }

    private IEnumerator Morder()
    {
        while (true)
        {
            vida -= 10;
            if (vida <= 0)
                Destroy(gameObject);
            yield return new WaitForSeconds(1.0f);
        }
    }
   
}
