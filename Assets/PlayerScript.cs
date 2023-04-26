using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int speed;
    public int jumpSpeed;
    public int jumpAmount;
    public bool isJumping;
    public Rigidbody2D rb;    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            PlayerMovementX();
        }

        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false && jumpAmount >= 0)
        {
            PlayerMovementY();
            jumpAmount--;
            Debug.Log("isJumping = true");

        }
        else if(jumpAmount == 0)
        {
            isJumping = true;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isJumping = false;
            jumpAmount = 2;
            Debug.Log("isJumping = False");
        }
    }


    private void PlayerMovementX(){
        float horizontalinput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(horizontalinput, 0f, 0f);
    }

    private void PlayerMovementY()
    {
        rb.AddForce(Vector3.up * jumpSpeed);
    }

}
