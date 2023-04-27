using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus2Script : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().AddJump();
            GameObject.FindGameObjectWithTag("GameController").GetComponent<UIScript>().UIJumpRefresh();
            Destroy(this.gameObject);
        }

    }
}
