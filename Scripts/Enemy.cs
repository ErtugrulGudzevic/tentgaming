using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GM gm;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        gm = GameObject.Find("GameManager").GetComponent<GM>();
        if (gm.powerOn == true)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 120);
        }
        else
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("collectable")|| collision.gameObject.CompareTag("Heart") || collision.gameObject.CompareTag("Power"))
        {
            Destroy(collision.gameObject);
        }
    }
}
