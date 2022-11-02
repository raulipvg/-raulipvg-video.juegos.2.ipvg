using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsController : MonoBehaviour
{
    public static SoundsController inst;
    AudioSource _audioSource;
    void Awake()
    {
        if (inst == null)
        {
            inst = this;
            DontDestroyOnLoad(gameObject);
            _audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void ControlVolumen(float volumen)
    {
        inst._audioSource.volume = volumen;
    }

    public static void Play()
    {
        inst._audioSource.Play();
    }
}
