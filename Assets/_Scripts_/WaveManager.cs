using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public Transform[] pathPoints;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnTimes;
    [SerializeField] private float spawnDelay;
    
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    public void Spawn()
    {
        StartCoroutine(SpawnEnemy());
        
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
                
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
                
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
                
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);
        
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(enemyPrefab, transform.position, quaternion.identity);

    }
}
