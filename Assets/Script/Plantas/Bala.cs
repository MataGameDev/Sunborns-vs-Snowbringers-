using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [Header("Velocidad de Bala")]
    public float speed = 6f;

    [Header("Tiempo de Destruccion de Bala")]
    public float destroyTimer = 3;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,destroyTimer);
    }
    private void Update()
    {//start update
        //llamar a la funcion que mueve la bala
        Move();
    }//end update

    //funcion que mueve la bala
    void Move()
    {//start move
        //variable temporal que guarda la posicion de la bala
        Vector3 _temp = transform.position;

        //adicion de la posicion temporal en x
        //disparar de izquierda a derecha
        _temp.x += speed * Time.deltaTime;

        //actializar la posicion de bala usando el vector temporal
        transform.position = _temp;
    }//end move
    
    private void OnTriggerEnter2D(Collider2D _other)
    {
        if (_other.tag == "Nieve")
        {
            Destroy(gameObject);
        }
    }
}
