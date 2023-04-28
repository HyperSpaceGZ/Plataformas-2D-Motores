using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpeningScript : MonoBehaviour
{
    public SpriteRenderer ClosedDoor;
    public bool IsDoorOpened;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        ClosedDoor.enabled = false;
        IsDoorOpened = true;
    }
}
