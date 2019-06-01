using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
    public static Fader instance;
    public SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void fadeToBlack()
    {
        Debug.Log("fade");
        for (int i = 0; i <= 100; i++)
        {
            spriteRenderer.color = new Color(0f, 0f, 0f, i);
        }
    }

}
