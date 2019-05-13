using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TafelController : MonoBehaviour
{
    // functional variables
    public bool inCollider;

    // lines
    public string[] lines;
    
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
            TextBoxManager.instance.ShowText(lines);
        }
    }
}
