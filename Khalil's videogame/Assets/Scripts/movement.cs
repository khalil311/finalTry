using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x + collision.bounds.size.x * 2, collision.gameObject.transform.position.y,0);
        }
    }
}
