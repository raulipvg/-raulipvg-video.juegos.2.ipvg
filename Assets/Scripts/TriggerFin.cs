using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Choque con otro trigger");
        if (other.gameObject.CompareTag("Personaje"))     // Identifica mediante la etiqueta si la colisión fue por una bala
        {
            Debug.Log("Personaje llego a la meta");

            FindObjectOfType<GameController>().Fin(3);            
        }
    }
}
