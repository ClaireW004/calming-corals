using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class educationalPopupTriggers : MonoBehaviour
{
    public Slider slider;

    public GameObject angelfish;
    private bool angelfishShown = false;
    public GameObject angelfishModel;

    public GameObject regalangelfish;
    private bool regalangelfishShown = false;
    public GameObject regalangelfishModel;

    public GameObject moorishidol;
    private bool moorishidolShown = false;
    public GameObject moorishidolModel;


    public GameObject clownfish;
    private bool clownfishShown = false;
    public GameObject clownfishModel;


    public GameObject turtle;
    private bool turtleShown = false;
    public GameObject turtleModel;

    public GameObject endingScreen;
    private bool endingShown = false;

    void Start()
    {
        
    }

    void Update()
    {
        /*
        Value Ranges: 1.5, 3.5, 6.0, 8.0, 10.0
        */
        if (slider.value >= 3.0 && slider.value < 6.0 && !angelfishShown) {
            angelfish.SetActive(true);
            angelfishShown = true;
            angelfishModel.SetActive(true);
        }
        else if (slider.value >= 6.0 && slider.value < 9.0 && !regalangelfishShown) {
            regalangelfish.SetActive(true);
            regalangelfishShown = true;
            regalangelfishModel.SetActive(true);
        }
        else if (slider.value >= 9.0 && slider.value < 10.0 && !clownfishShown) {
            clownfish.SetActive(true);
            clownfishShown = true;
            clownfishModel.SetActive(true);
        }
        else if (slider.value >= 10.0 && !turtleShown) {
            turtle.SetActive(true);
            turtleShown = true;
            turtleModel.SetActive(true);
        }
        // else if (slider.value >= 6.0 && slider.value < 8.0 && !moorishidolShown) {
        //     moorishidol.SetActive(true);
        //     moorishidolShown = true;
        //     moorishidolModel.SetActive(true);
        // }
        // else if (slider.value >= 8.0 && slider.value < 10.0 && !clownfishShown) {
        //     clownfish.SetActive(true);
        //     clownfishShown = true;
        //     clownfishModel.SetActive(true);
        // }
        // else if (slider.value >= 10.0 && !turtleShown) {
        //     turtle.SetActive(true);
        //     turtleShown = true;
        //     turtleModel.SetActive(true);
        // }
        if (turtleShown && !turtle.activeSelf && !endingShown) {
            endingScreen.SetActive(true);
            endingShown = true;
        }
    }
}
