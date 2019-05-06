using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public bool inCollider;
    public bool leverActive = false;

    public string spritePath = "Sprites/Lever";

    private Sprite[] sprites;

    public void Start()
    {
        sprites = Resources.LoadAll<Sprite>(spritePath);
        Debug.Log(sprites);
    }
    
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
                Debug.Log("The Lever was de-activated!");   
                leverActive = false;
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
            }
            else
            {
                Debug.Log("The Lever was activated!");  
                leverActive = true;
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
            }
        }
    }
}
