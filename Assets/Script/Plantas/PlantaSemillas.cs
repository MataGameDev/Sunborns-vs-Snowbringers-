using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantaSemillas : MonoBehaviour
{
    public float CoolDown;
    private float CoolDownBase = 0.5f;
    public Transform spawnPoint;//de donde dispara el enemigo
    public GameObject Semilla; //referencia al gameobject de la bala enemiga
    // Start is called before the first frame update
    
    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(CoolDownBase);
            
            GameObject _Semilla = Instantiate(Semilla, spawnPoint.position, Quaternion.identity);
            CoolDownBase = CoolDown;

        }
    }
}
