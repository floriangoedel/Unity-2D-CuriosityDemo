using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static DoorManager instance;
    
    public Sprite backgroundClosedDoor;
    public Sprite backgroundOpenedDoor;
    private SpriteRenderer renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void openDoor()
    {
        renderer.sprite = backgroundOpenedDoor;
    }
    
    public void closeDoor()
    {
        renderer.sprite = backgroundClosedDoor;
    }
}
