using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDeleter : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Character");
        speed =player.GetComponent<PlayerMovement>().speed;
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("platform") )
        {
            
            GameObject GameManager = GameObject.Find("GameManager");
            MapGenarator pD = GameManager.GetComponent<MapGenarator>();
            pD.PlatformAdder(gameObject.transform.position.x + 87.56f);
            
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Heart") || collision.gameObject.CompareTag("Power") || collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("collectable"))
        {

            Destroy(collision.gameObject);
        }
    }
}
