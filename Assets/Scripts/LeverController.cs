using UnityEngine;

public class LeverController : MonoBehaviour
{
    public bool inCollider;
    public bool leverActive = false;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        inCollider = true;
    }

    public void OnTriggerExit2D(Collider2D other)
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
