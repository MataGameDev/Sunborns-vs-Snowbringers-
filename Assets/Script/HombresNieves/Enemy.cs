using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed; //velocidad del enemigo
    public float speedBase;
    public float healt;

    static public int cantidad;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = speedBase;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }
    void MoveEnemy()
    {
        //variable que guarda la posicion actual del enemigo
        Vector3 _temp = transform.position;

        //decremento de la pos x del enemigo usando el tiempo
        _temp.x -= speed * Time.deltaTime;

        //actualizar la posicion  de este objeto usando el vector temp
        transform.position = _temp;
    }

    private void OnTriggerEnter2D(Collider2D _other)
    {
        if (_other.tag == "Bala")
        {
            healt -= 10f;
            if (healt <= 0)
            {
                cantidad++;
                Destroy(gameObject);
            }
        }
        if (_other.tag == "BalaSolar")
        {
            healt -= 20f;
            if (healt <= 0)
            {
                cantidad++;
                Destroy(gameObject);
            }
        }
        
        if (_other.tag == "Fuego")
        {
                cantidad++;
                Destroy(gameObject);

        }
        
        if (_other.tag == "BalaStun")
        {
            healt -= 10f;
            speed = speedBase/2;
            if (healt <= 0)
            {
                cantidad++;
                Destroy(gameObject);
            }
        }
        if (_other.tag == "Planta")
        {
            speed = 0.0f;
        }
 
    }

    private void OnTriggerExit2D(Collider2D _other)
    {
        if (_other.tag == "Planta")
        {
            speed = speedBase;
        }
    }
}
