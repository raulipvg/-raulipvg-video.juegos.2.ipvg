using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]
    [Range(1, 3)]
    private int dificultad = 1;

    [SerializeField] int toques = 0;

    [SerializeField] public TMP_Text Tiempo;
    [SerializeField] public TMP_Text Toques;
    [SerializeField] public TMP_Text Enemigos;
    public TMP_Text nombreUsuario;


    private static int vidasEnemigos;
    private static int vidaPlayer = 3;
    private int time = 30;
    private int tiempoInicial;
    int enemigosDestruidos= 0;

    public GameObject gameObjectActivar;
    public GameObject GameOver;
    public GameObject GameOverExito;
    // Start is called before the first frame update
    void Start()
    {
        dificultad = Configuraciones.dificultad;
        tiempoInicial = time;
        //SETEO EN 0 LAS VARIABLES
        PlayerPrefs.SetInt("tiempo", 0);
        PlayerPrefs.SetInt("toques", 0);
        PlayerPrefs.SetInt("enemigosDestruidos", 0);

        //SceneManager.LoadScene("Escena 0");
        Debug.Log("Game Controller Activado");
        Time.timeScale = 1;  //Juego Iniciado
        StartCoroutine(timer());
        vidasEnemigos = dificultad;
    }

    IEnumerator timer()
    {
        PlayerPrefs.SetInt("segundos", time);
        yield return new WaitForSeconds(1);
        time--;
        PlayerPrefs.SetInt("tiempo", tiempoInicial-time);
        // SI PASA DEL TIEMPO ESTABLECIDO, FIN DEL JUEGO
        if (time <= 0)
        {
            StopCoroutine(timer());
            Fin(2);
        }
        
        Debug.Log("Te quedan: "+time);
        yield return timer();
      
        
    }
    public void Fin(int i)
    {
        if (i == 1) // PERDIO POR TOQUES
        {
            FindObjectOfType<Sonidos>().PlayFinPerder();
            Debug.Log("Juego Terminado "+ Configuraciones.nombreUsuario +", Te tocaron 3 veces =(");
            StopAllCoroutines();
            Time.timeScale = 0; //Juego Pausado
            gameObjectActivar.SetActive(true);
            //AudioController.Pausar();
            esperaSegundos(5);
            SceneManager.LoadScene("Escena 0");

        }
        else if(i == 2) // PERDIO POR TIMEOUT
        {
            FindObjectOfType<Sonidos>().PlayFinPerder();
            Debug.Log("Juego Terminado " + Configuraciones.nombreUsuario + ", Se te fue el tiempo");
            StopAllCoroutines();
            Time.timeScale = 0; //Juego Pausado
            GameOver.SetActive(true);
            
            //Debug.Log("JUEGO REINICIADO");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (i == 3) //LLEGO A LA META
        {
            
            FindObjectOfType<Sonidos>().PlayFinGanar();
            Debug.Log("Juego Terminado " + Configuraciones.nombreUsuario + ", FELICIDADES!!");
            StopAllCoroutines();

            nombreUsuario.text = Configuraciones.nombreUsuario;
           Toques.text = Convert.ToString(PlayerPrefs.GetInt("toques"));
           Tiempo.text = Convert.ToString(PlayerPrefs.GetInt("tiempo") + " segundos");
           Enemigos.text = Convert.ToString(PlayerPrefs.GetInt("enemigosDestruidos"));

            //Debug.Log("Toques "+PlayerPrefs.GetInt("toques"));
            //Debug.Log("Tiempo " + PlayerPrefs.GetInt("tiempo"));
            //Debug.Log("Enemigos Destruidos " + PlayerPrefs.GetInt("enemigosDestruidos"));

            Time.timeScale = 0; //Juego Pausado
            GameOverExito.SetActive(true);
        }
    }


    public static int getVidaEnemigos() { return vidasEnemigos; }

    public static int getVidaPlayer() { return vidaPlayer; }

    public void Toque()
    {
        FindObjectOfType<Sonidos>().PlayColision(); // SONIDO DE COLISION
        toques = toques + 1; // Contador de toques
        PlayerPrefs.SetInt("toques", toques); // TOQUES por player pref
        Debug.Log("Toques " + toques);
        if (toques >= vidaPlayer) 
        {
            FindObjectOfType<GameController>().Fin(1);
        }

    }

    public void DestruyeEnemigo()
    {
        enemigosDestruidos++;
        PlayerPrefs.SetInt("enemigosDestruidos", enemigosDestruidos);
    }

    private IEnumerable esperaSegundos(int seg)
    {
        yield return new WaitForSeconds(seg);
    }
   
}
