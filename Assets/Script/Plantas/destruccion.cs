using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruccion : MonoBehaviour
{

    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnExplosion()
    {   
        GameObject _explosion = Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    
    public void desaparercer()
    {
        Destroy(gameObject);
    }
}
