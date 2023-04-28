using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoorScript : MonoBehaviour
{
    private DoorOpeningScript DoorOpeningScript;
    void Start()
    {
        DoorOpeningScript = GameObject.FindGameObjectWithTag("Door").GetComponent<DoorOpeningScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (DoorOpeningScript.IsDoorOpened = true &&  collision.gameObject.tag == "Player")
        {
            Debug.Log("YOU WIN!!!");
            SceneManager.LoadScene("Win");
        }

    }
}
