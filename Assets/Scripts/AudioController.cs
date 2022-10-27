using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController inst;
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
        inst._audioSource.volume = volumen / 100;
    }

    public static void Pausar()
    {
        inst._audioSource.Pause();
    }

    public static void Play()
    {
        inst._audioSource.Play();
    }

}
