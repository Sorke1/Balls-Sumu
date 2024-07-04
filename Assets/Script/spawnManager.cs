using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject PowerUp;
    private float range = 9;
    public int enemyCount;
    public int enemyWaveNumber = 1;
     


    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(1);
        Instantiate(PowerUp, GenerateSpawnPosition(), PowerUp.transform.rotation);

    }

    private void SpawnEnemyWave(int enemyWaveNumber)
    {
        for (int i = 0; i < enemyWaveNumber; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation); // Use Quaternion.identity for no rotation
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-range, range);
        float spawnPosZ = Random.Range(-range, range);
        Vector3 spawnPosition = new Vector3(spawnPosX, 0, spawnPosZ); // Corrected vector creation
        return spawnPosition; // Corrected return statement
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyMove>().Length; // Corrected method name
        if (enemyCount == 0)
        {
            enemyWaveNumber++;
            SpawnEnemyWave(enemyWaveNumber);
            Instantiate(PowerUp, GenerateSpawnPosition(), PowerUp.transform.rotation);

        }
    }
}
