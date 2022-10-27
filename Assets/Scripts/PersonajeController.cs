using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    [SerializeField] float velocidadAvance = 70;                                          //velocidad a la que avanzará sentido adelante/atrás
    [SerializeField] float velocidadRotacion = 100;             //velocidad de rotación, al mover las flechas izquierda/derecha

    static int vidaPlayer;
    // Start is called before the first frame update
    // Update is called once per frame
    public CharacterController player;
    public float horizontal;
    public float vertical;
    private Vector3 rotation;


    private void Start()
    {
        player= GetComponent<CharacterController>();
        
        vidaPlayer = GameController.getVidaPlayer();
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");                     //captura las teclas en horizontal (izquierda/derecha)
        float vertical = Input.GetAxis("Vertical");                         //captura las teclas en vertical (arriba/abajo)
    }
    private void FixedUpdate()
    {
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * velocidadRotacion * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        player.Move(move * velocidadAvance);
        this.transform.Rotate(this.rotation);
    }

    private void OnCollisionEnter(Collision other)
    {
        // ATAQUE DEL ENEMIGO MEDIANTE UN TOQUE
        if (other.gameObject.CompareTag("Enemigo"))     // Identifica mediante la etiqueta si la colisión fue por una bala
        {     
            FindObjectOfType<GameController>().Toque();
        }
       
    }

    public static int getVidaPlayer() { return vidaPlayer; }


}
