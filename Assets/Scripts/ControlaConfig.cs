using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlaConfig : MonoBehaviour
{
    public TMP_InputField nombreUsuario;
    public TMP_Dropdown selectDificultad;
    void Awake()
    {
        nombreUsuario.text = Configuraciones.nombreUsuario;
        selectDificultad.value = Configuraciones.dificultad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
