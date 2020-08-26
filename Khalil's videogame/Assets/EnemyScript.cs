using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int health;
    public float speed = 100f;
    public Transform target;

    
    // Start is called before the first frame update
    public void TakeDamge (int damage)
    {
        health -= damage;
        if (health<= 0)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed); 
    }
}
