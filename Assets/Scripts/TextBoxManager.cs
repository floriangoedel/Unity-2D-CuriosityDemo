using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;
    public Text text;

    public string[] lines;
    public int currentLine = 0;

    public static TextBoxManager instance;
    
    void Start()
    {
        instance = this;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (textBox.activeInHierarchy)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (currentLine >= lines.Length - 1)
                {
                    textBox.SetActive(false);
                }
                else
                {
                    currentLine++;
                    text.text = lines[currentLine];    
                }
            }
        }
    }

    public void ShowText(string[] inputLines)
    {
        lines = inputLines;
        currentLine = 0;
        text.text = lines[currentLine];
        textBox.SetActive(true);
    }
}
