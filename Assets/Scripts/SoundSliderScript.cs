using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSliderScript : MonoBehaviour
{
    public Slider slider;


    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        //SoundsController.ControlVolumen(slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        //SoundsController.ControlVolumen(slider.value);
    }
}
