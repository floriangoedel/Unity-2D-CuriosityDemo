using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    // functional variables
    public bool inCollider;
    public bool isLeverActive = false;

    // sprite variables
    public Sprite activeLeverSprite;
    public Sprite inactiveLeverSprite;
    private SpriteRenderer renderer;

    public void Start()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.sortingLayerName = "Objects";
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
            if (isLeverActive)
            {
                Debug.Log("The Lever was de-activated!");   
                isLeverActive = false;
                renderer.sprite = inactiveLeverSprite;
            }
            else
            {
                Debug.Log("The Lever was activated!");  
                isLeverActive = true;
                renderer.sprite = activeLeverSprite;
            }
        }
    }
}
