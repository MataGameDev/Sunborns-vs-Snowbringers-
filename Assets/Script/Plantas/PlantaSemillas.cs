using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantaSemillas : MonoBehaviour
{
    public float coldownd;
    public Transform spawnPoint;//de donde dispara el enemigo
    public GameObject Semilla; //referencia al gameobject de la bala enemiga
    // Start is called before the first frame update
    
    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(coldownd);
            
            GameObject _Semilla = Instantiate(Semilla, spawnPoint.position, Quaternion.identity);
            
        }
    }
}
