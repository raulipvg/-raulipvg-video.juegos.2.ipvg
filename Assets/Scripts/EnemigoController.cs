using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.AI;

public class EnemigoController : MonoBehaviour
{
    [SerializeField]
    public Transform objetivo;
    public NavMeshAgent agente;
    static int vidaEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        vidaEnemigo = GameController.getVidaEnemigos();
        agente = GetComponent<NavMeshAgent>();
        agente.speed = agente.speed * Mathf.Pow(10,(Configuraciones.dificultad));
    }

     void FixedUpdate()
    {
        //agente.destination = objetivo.position;
    }
    // Update is called once per frame
    void Update()
    {
        agente.destination = objetivo.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Choque con otro trigger");
        if (other.gameObject.CompareTag("Bala"))     // Identifica mediante la etiqueta si la colisión fue por una bala
        {
            vidaEnemigo--;
            if (vidaEnemigo <= 0)                                      //Utiliza <= ya que puede recibir dos balas contínuas que no alcance a calcular, lo que podría dar un falso negativo a ==0
            {
                FindObjectOfType<GameController>().DestruyeEnemigo();  //Llama la función de GameController para aumentar el contador de enemigos destruídos
                Destroy(gameObject);                            //Destruye al enemigo que fue colisionado por la bala
                //FindObjectOfType<GameController>().Fin();
            }

            Destroy(other.gameObject); //Destruye la bala que colisionó al enemigo.
        }

    }
    


}
