using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public AudioSource _disparo;
    public AudioSource _colision;
    public AudioSource _finGanar;
    public AudioSource _finPerder;

     void Start()
    {
        _disparo.volume = PlayerPrefs.GetFloat("VolumenJuego");
        _colision.volume = PlayerPrefs.GetFloat("VolumenJuego");
        _finGanar.volume = PlayerPrefs.GetFloat("VolumenJuego");
        _finPerder.volume = PlayerPrefs.GetFloat("VolumenJuego");

    }
    public void PlayDisparo()
    {
        _disparo.Play();       
    }
    public void PlayColision()
    {
        _colision.Play();
    }
    public void PlayFinGanar()
    {
        _finGanar.Play();
    }
    public void PlayFinPerder()
    {
        _finPerder.Play();
    }

}
