using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject targetPrefab; // Assign the target prefab in the inspector
    public Transform[] spawnPoints; // Assign spawn points in the inspector
    public float spawnDelay = 1.0f; // Time between spawns

    private void Start()
    {
        StartCoroutine(SpawnTargets());
    }

    IEnumerator SpawnTargets()
    {
        while (true) // This loop will run forever
        {
            foreach (Transform spawnPoint in spawnPoints)
            {
                Instantiate(targetPrefab, spawnPoint.position, spawnPoint.rotation);
                yield return new WaitForSeconds(spawnDelay); // Wait for 1 second before spawning next target
            }
        }
    }
}
