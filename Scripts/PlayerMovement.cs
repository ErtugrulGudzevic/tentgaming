using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed =7.82F;
    public Rigidbody2D rb;
    private int floorCounter = 1;
    public float fallWaitSec=2f,playerPosY,playerPosX;
    GM gm;


    // JUMP PART
    public Vector3 jump;
    public float jumpForce =9.0f;
    public bool isGrounded,isJumping,isFalling =false;
    public float difficulty;
    //CoincColet
    public bool isTriggered = false;

    void Start()
    {
        difficulty = PlayerPrefs.GetFloat("diff");
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        playerPosX = rb.transform.position.x;
        speed = difficulty;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (playerPosX < rb.transform.position.x - 1)
        {
            isTriggered = false;
        }
        if (rb.transform.position.y < -2)
        {
            floorCounter = 0;
        }
        else if (rb.transform.position.y > 2)
        {
            floorCounter = 2;
        }
        else
        {
            floorCounter = 1;
        }
        
        /*
        

        //JUMP
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && floorCounter < 2)
        {
            isJumping = true;
            isGrounded = false;
            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
           
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            if (floorCounter < 2)
            {
                floorCounter++;
            }

        }
        */

        if ( rb.velocity.y < 0 && isJumping == true)
        {
            isJumping = false;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
            
        }


        /*
        //DOWN
        if (Input.GetKeyDown(KeyCode.S) && floorCounter> 0 && isGrounded)
        {
            isFalling = true;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            playerPosY = gameObject.transform.position.y;
            floorCounter--;
        }
        
         */
        if (playerPosY > gameObject.transform.position.y +3 && isFalling)
        {
            isFalling = false;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
           
        }
        
        
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    //COIN COLLECT AND ENEMY HİT
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Enemy") )
        {
            
            Destroy(collision.gameObject);
            gm = GameObject.Find("GameManager").GetComponent<GM>();
            gm.hitOnEnemy();
            
        }

        if (collision.CompareTag("collectable") && !isTriggered)
        {
           
            Destroy(collision.gameObject);
            gm = GameObject.Find("GameManager").GetComponent<GM>();
            gm.ScoreAdder(1);
            isTriggered = true;
        }
        if (collision.CompareTag("Heart") && !isTriggered)
        {

            Destroy(collision.gameObject);
            gm = GameObject.Find("GameManager").GetComponent<GM>();
            gm.HpAdder(1);
            isTriggered = true;
        }
        if (collision.CompareTag("Power") && !isTriggered)
        {
            Destroy(collision.gameObject);
            gm = GameObject.Find("GameManager").GetComponent<GM>();
            gm.getPower();
            isTriggered = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isTriggered = false;     
    }

  
    
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }


    }
   
    public void PlayerJump()
    {
        if ( isGrounded && floorCounter < 2)
        {
            isJumping = true;
            isGrounded = false;
            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);

            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            

        }
    }
    public void PlayerDown()
    {
        if ( floorCounter > 0 && isGrounded)
        {
            isFalling = true;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            playerPosY = gameObject.transform.position.y;
           
        }
       
    }

}
