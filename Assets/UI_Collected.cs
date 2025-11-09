using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Don't forget this line for TextMeshPro

public class UI_Collected : MonoBehaviour
{
    public TextMeshProUGUI variableText; 

    // The variable you want to display (example)
    public TrashCollected trashCollected; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // Update the text to reflect the current value of the variable
        variableText.text = "Trash Collected: " + trashCollected.currentScore.ToString(); 
    }
}