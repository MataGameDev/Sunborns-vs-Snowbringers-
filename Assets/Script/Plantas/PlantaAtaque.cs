using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlantaAtaque : MonoBehaviour
{
    public Plantas plantaBase;
    public Transform attackPoint;//de donde dispara el enemigo
    public GameObject[] bulletPrfab; //referencia al gameobject de la bala enemiga
    public LayerMask Nieve;
    [FormerlySerializedAs("coldownd")] public float cooldowns;
    public int rango;
    // Start is called before the first frame update
    
    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            RaycastHit2D hit = Physics2D.Raycast(attackPoint.position, Vector2.right, rango, Nieve);
            if (hit.collider != null)
            {
                yield return new WaitForSeconds(cooldowns);
                for (int i = 0; i < bulletPrfab.Length; i++)
                {
                    GameObject _bullet = Instantiate(bulletPrfab[i], attackPoint.position, Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
            }
        }
    }
}
