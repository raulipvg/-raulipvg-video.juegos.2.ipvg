using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InicializarPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textoBienvenido;

    public GameObject Bienvenido;
    void Awake()
    {
        actualizarNombre();
    }

    public void actualizarNombre()
    {
        textoBienvenido.text = "Bienvenido " + Configuraciones.nombreUsuario;
        Bienvenido.SetActive (true);

    }
   

}
