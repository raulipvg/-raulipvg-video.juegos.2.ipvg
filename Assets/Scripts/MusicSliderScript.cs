using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSliderScript : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        AudioController.ControlVolumen(slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        AudioController.ControlVolumen(slider.value);
    }
}
