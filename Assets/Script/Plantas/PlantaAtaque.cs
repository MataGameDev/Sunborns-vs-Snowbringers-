using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantaAtaque : MonoBehaviour
{
    public Plantas plantaBase;
    public Transform attackPoint;//de donde dispara el enemigo
    public GameObject bulletPrfab; //referencia al gameobject de la bala enemiga
    public LayerMask Nieve;
    // Start is called before the first frame update
    
    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(plantaBase.coldownd);

            RaycastHit2D hit = Physics2D.Raycast(attackPoint.position, Vector2.right, 12, Nieve);
            if (hit.collider != null)
            {
                GameObject _bullet = Instantiate(bulletPrfab, attackPoint.position, Quaternion.identity);
            }
        }
    }
}
