using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInGameSet : MonoBehaviour
{
    // Start is called before the first frame update

    public void Start()
    {
        if (!PlayerPrefs.HasKey("VolumenJuego"))
        {
            PlayerPrefs.SetFloat("VolumenJuego", 0.5f);
        }
        
    }
    public static void actualizarSonido(float value)
    {
        PlayerPrefs.SetFloat("VolumenJuego", value);

    }

}
