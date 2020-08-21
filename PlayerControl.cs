//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Estructura de datos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para generar el movimiento y desaparición del enemigo. 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{// inicio del cuerpo de la clase

    //+++++++área para declarar variables++++++

    //EL tipo dato  nombre de variable
    Rigidbody2D fisicasRB2D;
    // al declarar una variable como publica esta se podra visulizar en el inspector
    public float fuerzaSaltoPersonaje;

    public int vida;
    public int crayolas;
    public int puntajeGoma;
    public int puntajeTintero;
    public Text vidaa;
    public Text gomaa;
    public Text tinteroo;
    public Text crayolaa;
    private int scoreValue;
    //SerilizeField cumple con el muestreo de variables en el inspector pero mantiene su acceso privado
    [SerializeField]
    float velocidadPersonaje;
    [SerializeField]
    int a = 0;
    public SpriteRenderer spritePlayer;
    [SerializeField]
    private PlayerControl playerPuntaje;

    //*****************************************


    // Start sirve para inicializar datos, componentes y variables
    // carga todos mis GameObject, Componentes, acciones, valores o eventos 
    // al juego

    public void AddScore (int value)
    {
        vida += value;
        crayolas += value;
        puntajeGoma += value;
        puntajeTintero += value;
        UpdateScore();

    }
    void UpdateScore()
    {
        vidaa.text = "Vida: " + vida;
        crayolaa.text = "Crayolas: " + crayolas;
        gomaa.text = "Gomas: " + puntajeGoma;
        tinteroo.text = "Tinteros: " + puntajeTintero;
        
    }
    void Start()
    {               //lee el componente de cierto tipo
        fisicasRB2D = GetComponent<Rigidbody2D>();
        spritePlayer = GetComponent<SpriteRenderer>();
        fuerzaSaltoPersonaje = 9.7f;
        velocidadPersonaje = 2.0f;
        vida = 3;
        crayolas = 0;
        puntajeGoma = 0;
        puntajeTintero = 0;
        UpdateScore();
    }

    // Update sirve para utilizar los datos componentes y variables
    void Update()
    {
        // Voy a usar una entrada(Input) utilizo el operador punto para entrar en sus 
        //propiedades y elijo una estrada de tecla presionada
        // le indico que va representar en el mundo real esta entrada
        
        if (Input.GetKeyDown(KeyCode.Space))

        {  //variable a utilizar, agrega una duerza,
            //dirección en que agrega esa fuerza la magnitud con que aplicara la fuerza
            //agregqar o traducir a un impulso
            
            Debug.Log(a);
            if (a<3)
            {
                fisicasRB2D.AddForce(Vector2.up * fuerzaSaltoPersonaje, ForceMode2D.Impulse);
                Debug.Log(a);
                a = a + 1;
            }
            
        }


        

        //Voy usar una entrada input GetKey para el movimiento a izquierda y derecha de mi personaje
        if (Input.GetKey(KeyCode.RightArrow))
        {         //cambiar la velocidad del personaje de 0 a 1 en x //Lee y manten el valor actual de velocidad en y
            fisicasRB2D.velocity = new Vector2(velocidadPersonaje, fisicasRB2D.velocity.y);
       
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            fisicasRB2D.velocity = new Vector2(-velocidadPersonaje, fisicasRB2D.velocity.y);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            fuerzaSaltoPersonaje = 0;
            if (Input.GetKey(KeyCode.Space))
            {
                gameObject.GetComponent<Collider2D>().enabled = false;
            }

        }
        else
        {
            fuerzaSaltoPersonaje = 5.0f;
            gameObject.GetComponent<Collider2D>().enabled = true;
        }


   

        if (vida <= 0)
        {
        
            Destroy(this.gameObject);
        }


        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.248059f, 8.2f), Mathf.Clamp(transform.position.y, -3.59f, 49.4f), transform.position.z);

    }

    private void OnCollisionEnter2D(Collision2D collision)//aqui se resetea el salto
    {
        
        a = 0;
    }




}// fin del cuerpo de la clase
