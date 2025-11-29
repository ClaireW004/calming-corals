using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class increaseSliderValue : MonoBehaviour
{
    public Slider slider;
    //public int value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void updateSliderValue(int addAmount) 
    {
        slider.value += addAmount;
    }
}
