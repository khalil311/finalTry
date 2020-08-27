using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public GameObject explode;
    public float speed = 30f;
    public Rigidbody2D rb;
    public int damage = 50;
    public PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        Destroy(gameObject, 1.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyMovement enemy = collision.GetComponent<EnemyMovement>();
        if (enemy != null)
        {
            enemy.TakeDamge(damage);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("i hit enemy");
            player.IncreaseScore();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(explode, transform.position, transform.rotation);
        }
        
    }
}
