using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public AudioSource _disparo;
    public AudioSource _colision;
    public AudioSource _finGanar;
    public AudioSource _finPerder;

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
