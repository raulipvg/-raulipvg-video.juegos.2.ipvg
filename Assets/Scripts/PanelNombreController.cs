using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelNombreController : MonoBehaviour
{
    public TMP_InputField input_nombre;
    public Button continuar;
    public GameObject panelMenu;

   

    public void verificaNoVacio()
    {
        if(input_nombre.text.Length != 0)
        {
            continuar.enabled = true;
            Configuraciones.nombreUsuario = input_nombre.text;
        }

        
    }

    public void inicializado()
    {
        Configuraciones.setIniciado();
    }
}
