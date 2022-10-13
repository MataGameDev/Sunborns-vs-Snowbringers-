using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class SpawnEnemy : MonoBehaviour
{
    public GameObject Nieve;
    public Transform spawns;
    public float coldownd;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Start ()
    {
        while (true)
        {
            yield return new WaitForSeconds(coldownd);
            var obstaclesSpawnPoints = new List<GameObject>();
            foreach (Transform child in spawns)
            {
                if (child.CompareTag("Spawn"))
                {
                    obstaclesSpawnPoints.Add(child.gameObject);
                }
            }

            if (obstaclesSpawnPoints.Count > 0)
            {
                var spawnPoint = obstaclesSpawnPoints[Random.Range(0, obstaclesSpawnPoints.Count)];
                var spawnPos = spawnPoint.transform.position;
                var newObstacle = Instantiate(Nieve, spawnPos, Quaternion.identity);
            }

            coldownd = 7.0f;
        }
    }
}
