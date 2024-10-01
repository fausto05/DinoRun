using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObstaculos : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaculosPrefab;
    void Start()
    {
        StartCoroutine(SpawnObstaculos());
    }

    
    private IEnumerator SpawnObstaculos()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, obstaculosPrefab.Length);
            float minTime = 1.5f;
            float maxTime = 3f;
            float randomTime = Random.Range(minTime, maxTime);

            Instantiate(obstaculosPrefab[randomIndex], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
