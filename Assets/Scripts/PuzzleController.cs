using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    public bool isSolved;
    
    public GameObject lever1;
    public GameObject lever2;
    public GameObject lever3;

    private PlayerInteract leverController1;
    private PlayerInteract leverController2;
    private PlayerInteract leverController3;
    
    // Start is called before the first frame update
    void Start()
    {
        leverController1 = lever1.GetComponent<PlayerInteract>();
        leverController2 = lever2.GetComponent<PlayerInteract>();
        leverController3 = lever3.GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
        if (leverController1.isLeverActive && !leverController2.isLeverActive && leverController3.isLeverActive)
        {
            if (!isSolved)
            {
                string[] lines = {"Du hast das Rätsel bestanden!"};
                TextBoxManager.instance.ShowText(lines);
                DoorManager.instance.openDoor();
                isSolved = true;   
            }
        }
        else
        {
            DoorManager.instance.closeDoor();
            isSolved = false;
        }
    }
}
