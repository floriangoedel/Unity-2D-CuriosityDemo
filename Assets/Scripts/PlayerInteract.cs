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
    
    // text lines
    public string[] linesWhenActive;
    public string[] linesWhenInactive;
    
    public void Awake()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();
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
                isLeverActive = false;
                renderer.sprite = inactiveLeverSprite;
            }
            else
            {
                isLeverActive = true;
                renderer.sprite = activeLeverSprite;
            }
        }
    }
}
