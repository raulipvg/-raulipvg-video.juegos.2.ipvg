using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelesSonidoController : MonoBehaviour
{

    public AudioSource _nivel1;
    public AudioSource _nivel2;
    public AudioSource _nivel3;
    // Start is called before the first frame update
    void Start()
    {
        if (Configuraciones.dificultad == 0)
        {
            _nivel1.volume = PlayerPrefs.GetFloat("VolumenJuego");
            _nivel1.Play();
        }
        else if (Configuraciones.dificultad == 1)
        {
            _nivel2.volume = PlayerPrefs.GetFloat("VolumenJuego");
            _nivel2.Play();
        }
        else
        {
            _nivel3.volume = PlayerPrefs.GetFloat("VolumenJuego");
            _nivel3.Play();
        }
    }

   
}
