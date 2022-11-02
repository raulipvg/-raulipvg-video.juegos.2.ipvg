using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Configuraciones : MonoBehaviour
{
    [SerializeField]  public static string nombreUsuario;
    [SerializeField]  public TMP_InputField input_nombreUsuario;
    [SerializeField]  public static int dificultad = 0;
    [SerializeField]  public static bool nombreIngresado = false;
    public  Configuraciones conf;

    void Awake()
    {
        if(conf == null)
        {
            conf = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void setNombreUsuario(string usuario)
    {
        nombreUsuario = usuario;
    }

    public static string getNombreUsuario()
    {
        return nombreUsuario;
    }

    public static void cambiarDificultad(int i)
    {
        dificultad = i;
    }

    public static int getDificultad()
    {
        return dificultad;
    }

    public static void setIniciado(){
        nombreIngresado = !nombreIngresado;
    }

    public static bool getIniciado()
    {
        return nombreIngresado;
    }
}
