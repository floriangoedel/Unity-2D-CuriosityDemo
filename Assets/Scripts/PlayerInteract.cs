using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public bool inCollider;
    public bool leverActive = false;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        inCollider = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        inCollider = false;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && inCollider)
        {
            if (leverActive)
            {
                leverActive = false;
                Debug.Log("The Lever was de-activated!");   
            }
            else
            {
                leverActive = true;
                Debug.Log("The Lever was activated!");  
            }
        }
    }
}
