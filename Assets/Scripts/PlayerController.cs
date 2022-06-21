using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 10f;
    
    public Rigidbody2D playerRb;

    private Vector2 _movement;

    //animator
    public Animator playerAnimator;
    private Vector2 _previousPosition;

    //jumper
    public float jumpPower=5;
    bool ground;

    private void Start()
    {
        _previousPosition = playerRb.position;
    }

    private void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        //_movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        //if (ground == true){ Debug.Log("Ground is true.");}
    }

    private void FixedUpdate()
    {
        float translation = Input.GetAxis("Horizontal") * playerSpeed;
        transform.Translate(Mathf.Abs(translation), 0, 0);
        if (translation == 0)
        {
            playerAnimator.SetBool("moving", false);
        }
        else
        {
            playerAnimator.SetBool("moving", true);
            if (translation > 0) 
            {
                transform.eulerAngles = new Vector3(0, 0, 0); 
                playerAnimator.SetInteger("direction", 3);
            }
            if (translation < 0) 
            {
                transform.eulerAngles = new Vector3(0, 180, 0); 
                playerAnimator.SetBool("moving", true);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground") 
        {
            ground = true; 
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" ) { ground = false; }

    }

    private void Jump()
    {
        if (ground)
        {
            
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpPower);
            ground = false;
            Debug.Log("FUCK");
        }
    }
}
