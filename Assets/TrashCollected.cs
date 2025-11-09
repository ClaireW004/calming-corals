using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCollected : MonoBehaviour
{
    [SerializeField] public int currentScore = 0;

    // Start is called before the first frame update 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Add score function
    public void AddScore(int amount)
    {
        currentScore += amount;
    }
}