using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 3f;
    public bool isGameOver = false;
    private Rigidbody2D playerRb;
    private Animator playerAmin;
    public bool isClimbing;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAmin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver != true)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            if (horizontalInput == 0)
            {
                
                
            }
            else
            
            if(horizontalInput > 0)
            {
                playerAmin.SetFloat("Run",horizontalInput);
                transform.Translate(Vector2.right * speed * Time.deltaTime * horizontalInput);
                transform.eulerAngles = new Vector2(0, 0);
            }
            else 

            if(horizontalInput < 0)
            {
                playerAmin.SetFloat("Run", -horizontalInput);
                transform.Translate(Vector2.left * speed * Time.deltaTime * horizontalInput);
                transform.eulerAngles = new Vector2(0, 180);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
                playerAmin.SetBool("Jump", true);
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {

                playerAmin.SetBool("Jump", false);
                

            }

            if(isClimbing == true)
            {
                playerRb.isKinematic = true;
                transform.Translate(Vector2.up * speed * Time.deltaTime * verticalInput);
                Debug.Log("climb");
            }
            else
            {
                playerRb.isKinematic = false;
            }
           
        }
    }
}
