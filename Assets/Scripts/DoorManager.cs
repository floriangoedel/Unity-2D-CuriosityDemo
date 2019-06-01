using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static DoorManager instance;
    
    public Sprite backgroundClosedDoor;
    public Sprite backgroundOpenedDoor;
    private SpriteRenderer renderer;
    public BoxCollider2D doorCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void openDoor()
    {
        renderer.sprite = backgroundOpenedDoor;
        doorCollider.isTrigger = true;
    }
    
    public void closeDoor()
    {
        renderer.sprite = backgroundClosedDoor;
        doorCollider.isTrigger = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Fader.instance.fadeToBlack();
    }
}
