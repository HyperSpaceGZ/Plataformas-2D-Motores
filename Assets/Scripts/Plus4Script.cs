using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus4Script : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().AddJump4();
            GameObject.FindGameObjectWithTag("GameController").GetComponent<UIScript>().UIJumpRefresh();
            Destroy(this.gameObject);
        }

    }
}
