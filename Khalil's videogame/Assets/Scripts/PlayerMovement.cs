using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public int upwardspeed = 100;
    private bool alreadyjumping = true;
    public int speed = 10;
    public float h;
    public GameObject bulletprefab;

    private float timeSinceLastShot;
    public float fireRate;
    public GameObject Enemy;

    public int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        timeSinceLastShot = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Mouse0) && Time.timeSinceLevelLoad >= timeSinceLastShot + fireRate)
        {
            shoot();
        }
        h = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = Vector2.right * h * speed;
           
        if (Input.GetKey(KeyCode.UpArrow) && alreadyjumping)
        {
            rb2d.AddForce(Vector2.up * upwardspeed);
            alreadyjumping = false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        alreadyjumping = true;
        if (col.gameObject.tag == "OBSTACLE")
        {
            Destroy(gameObject);
        }
    }
    void shoot()
    {
        
        Instantiate(bulletprefab, transform.position, transform.rotation).GetComponent<Bullet>().player =this;
        timeSinceLastShot = Time.timeSinceLevelLoad;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    
}
