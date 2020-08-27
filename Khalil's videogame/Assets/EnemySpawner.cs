using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   

    public GameObject enemyPrefab;
    public float spawnRate;
    public Transform target;
    

    // Start is called before the first frame update
    void Start()
    {
       
        InvokeRepeating("Spawn", 3, spawnRate);
        
    }

    public void Spawn()
    {
        Instantiate(enemyPrefab, new Vector2(Random.Range(-6, 7), transform.position.y), enemyPrefab.transform.rotation).GetComponent<EnemyMovement>().target = target;
    }


}
