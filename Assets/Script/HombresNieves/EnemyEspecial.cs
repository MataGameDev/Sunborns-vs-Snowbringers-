using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEspecial : MonoBehaviour
{
    [SerializeField]private GameObject CrioPrefab;

    private void explotar()
    {
        GameObject _explosion = Instantiate(CrioPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
        Enemy.cantidad++;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Planta")
        {
            explotar();
        }
    }
}
