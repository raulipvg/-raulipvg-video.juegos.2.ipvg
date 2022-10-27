using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject BalaPrefab;   // Obtenida de la bala en Unity. Este objeto prefab tiene sus propiedades modificadas (como la posición). Revisar en los assets.
    //Agregar Bala Velocidad
    [SerializeField]
    public float BalaVelocidad;

    // Update is called once per frame
    void Update()
    {
        //Input.GetButtonDown
        if (Input.GetKeyDown("space"))
        {

            //1-Instancia la BalaPrefab y le asigna Personaje como padre.
            GameObject BalaTemporal = Instantiate(BalaPrefab, gameObject.GetComponent<PersonajeController>().transform);

            //Obtener Rigidbody para agregar Fuerza. 
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

            //Agregar la fuerza a la Bala
            rb.AddForce(transform.forward * BalaVelocidad);

            //Debemos Destruir la bala
            Destroy(BalaTemporal, 5.0f);
        }
    }



}