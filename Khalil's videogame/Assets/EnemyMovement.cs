using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 4f;
    public PlayerMovement player;
    public int health;

    
    public void TakeDamge(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        player = target.GetComponent<PlayerMovement>();
        if (collision.collider.tag == "Ground")
        {
            player.IncreaseScore();
            Destroy(gameObject);
        }
        
    }
}
