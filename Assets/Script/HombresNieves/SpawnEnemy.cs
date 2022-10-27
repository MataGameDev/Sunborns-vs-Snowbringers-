using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] Nieve;
    public int[] rondas;
    public Transform spawns;
    public float coldownd;
    private int count;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Start ()
    {
        while (true)
        {
            var obstaclesSpawnPoints = new List<GameObject>();
            foreach (Transform child in spawns) {
                if (child.CompareTag("Spawn"))
                {
                    obstaclesSpawnPoints.Add(child.gameObject);
                }
            }
//clear
            for (int j = 0; j < rondas.Length; j++)
            {
                for (int i = 0; i < rondas[j]; i++)
                {
                    var spawnPoint = obstaclesSpawnPoints[Random.Range(0, obstaclesSpawnPoints.Count)];
                    var spawnPos = spawnPoint.transform.position;
                    var newObstacle = Instantiate(Nieve[count], spawnPos, Quaternion.identity);
                    count++;
                    yield return new WaitForSeconds(coldownd);
                }
                yield return new WaitForSeconds(6.0f);    
            }
        }
    }
}
