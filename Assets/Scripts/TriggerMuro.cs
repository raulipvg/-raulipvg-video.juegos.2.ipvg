using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMuro : MonoBehaviour
{
    private void OnTriggerEnter(Collider colision)
    {

        
        if (colision.gameObject.CompareTag("Bala"))     // Identifica mediante la etiqueta si al colisión fue por una bala
        {
            Debug.Log("Muro");
            Destroy(colision.gameObject);               // Destruye la bala
        }
        else
        {
            //Debug.Log("CHOKE CON ALGO");
        }
    }
}
