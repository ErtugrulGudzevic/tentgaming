using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public GameObject player;
    public PlayerMovement py;
    // Start is called before the first frame update
    void Start()
    {
        py = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            py.PlayerDown();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            py.PlayerJump();
        }
    }
}
