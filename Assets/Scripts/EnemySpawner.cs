using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject spawnedEnemy;

    public int spawnTime;

    public GameObject enemyPrefab;

    public AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnEnemies", spawnTime);
        backgroundMusic.Play();
  
    }

    void spawnEnemies()
    {
        Invoke("spawnEnemies", spawnTime);
        float randomX = Random.Range(-10, 10);
        float randomY = Random.Range(10, 20);
        float randomZ = Random.Range(5, 30);
        spawnedEnemy = Instantiate(enemyPrefab);
        spawnedEnemy.transform.position = new Vector3(randomX, randomY, randomZ);
    }
}
