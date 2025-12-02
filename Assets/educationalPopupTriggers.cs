using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class educationalPopupTriggers : MonoBehaviour
{
    public Slider slider;

    public GameObject angelfish;
    private bool angelfishShown = false;

    public GameObject regalangelfish;
    private bool regalangelfishShown = false;

    public GameObject moorishidol;
    private bool moorishidolShown = false;

    public GameObject clownfish;
    private bool clownfishShown = false;

    public GameObject turtle;
    private bool turtleShown = false;
    public GameObject angel;
    //private bool turtleShown = false;

    void Start()
    {
        
    }

    void Update()
    {
        /*
        Value Ranges: 1.5, 3.5, 6.0, 8.0, 10.0
        */
        if (slider.value >= 1.5 && slider.value < 3.5 && !angelfishShown) {
            angelfish.SetActive(true);
            angelfishShown = true;
            //Fish Code
            angel.SetActive(true);

        }
        else if (slider.value >= 3.5 && slider.value < 6.0 && !regalangelfishShown) {
            regalangelfish.SetActive(true);
            regalangelfishShown = true;
        }
        else if (slider.value >= 6.0 && slider.value < 8.0 && !moorishidolShown) {
            moorishidol.SetActive(true);
            moorishidolShown = true;
        }
        else if (slider.value >= 8.0 && slider.value < 10.0 && !clownfishShown) {
            clownfish.SetActive(true);
            clownfishShown = true;
        }
        else if (slider.value >= 10.0 && !turtleShown) {
            turtle.SetActive(true);
            turtleShown = true;
        }
    }
}
