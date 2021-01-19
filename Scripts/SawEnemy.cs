using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    float speed =4f;
    public Rigidbody2D rb;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();   
        if (gameObject.transform.position.y > 7.6f)
        {
            rb= GetComponent<Rigidbody2D>();
            speed = -4f;
            
        }
       if (gameObject.transform.position.y < -4.6f)
        {
            rb = GetComponent<Rigidbody2D>();
            speed = 4f;
        }
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }
}
