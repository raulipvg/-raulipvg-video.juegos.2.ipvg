using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]
    [Range(1, 3)]
    private int dificultad = 1;

    [SerializeField]
    int toques = 0;
    //static int toques = 0; 


    private static int vidasEnemigos;
    private static int vidaPlayer = 3;

    // Start is called before the first frame update
    void Start()
    {
        vidasEnemigos = dificultad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Fin(int i)
    {
        if (i == 1)
        {
            Debug.Log("Juego Terminado, Te toquetearon mucho");
        }
        Debug.Log("JUEGO REINICIADO");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);         //Recarga la escena activa
    }


    public static int getVidaEnemigos() { return vidasEnemigos; }

    public static int getVidaPlayer() { return vidaPlayer; }

    public void Toque()
    {
        toques = toques + 1;

        Debug.Log("Toques " + toques);
        if (toques >= vidaPlayer)
        {
            FindObjectOfType<GameController>().Fin(1);
        }

    }
}
