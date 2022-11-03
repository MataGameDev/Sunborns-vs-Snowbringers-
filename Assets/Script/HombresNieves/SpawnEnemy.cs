using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;
public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] Nieves;
    public int[] rondas;
    public Transform[] spawns;
    public float coldownd;
    private int count;
    private int waveCount = 0;
    private int enemyCount;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Start ()
    {
        yield return new WaitForSeconds(5.0f);    
        while (true)
        {
            enemyCount = GameObject.FindGameObjectsWithTag("Nieve").Length;

            if (enemyCount == 0)
            {
                for (int i = 0; i < rondas[waveCount]; i++)
                {
                    Instantiate(Nieves[count], spawns[Random.Range(0, 5)].position, Quaternion.identity);
                    count++;
                    coldownd -= 0.05f;
                    yield return new WaitForSeconds(coldownd);
                }
                waveCount++;
            }
            yield return new WaitForSeconds(1.0f);
        }
    }
}
