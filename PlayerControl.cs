//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Estructura de datos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para general el control del avatar jugador
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{// inicio del cuerpo de la clase

    //+++++++área para declarar variables++++++

    Rigidbody2D fisicasRB2D;//es el componenete almacenado en la variable fisicasRB
    public float fuerzaSaltoPersonaje;//es la variavle publica que alamacena el componenete transform
    public int vida;//Sirve para decirle al jugador cuantas vidas tiene
    public int crayolas;//es la variable que guardara la informacion de crayolas 
    public int puntajeGoma;//es la variable que guardara la informacion de goma 
    public int puntajeTintero;//es la variable que guardara la informacion de tintero 
    public Text vidaa;//es la variable que mostrara el texto de vida 
    public Text gomaa;//es la variable que mostrara el texto de goma
    public Text tinteroo;//es la variable que mostrara el texto de tintero 
    public Text crayolaa;//es la variable que mostrara el texto de crayola 
    private int scoreValue;////es la variable que guardara la informacion de el score 
    [SerializeField]
    float velocidadPersonaje;//Funciona para ponerle una cantidad de fuerza a la velocidad con la que se mueve el personaje
    [SerializeField]
    int a = 0;//guarda la variable que conetndra la cantidad de saltos 
    public SpriteRenderer spritePlayer;//Sirve para asignarle un nombre al componente para así darle una función u orden
    [SerializeField]
    private PlayerControl playerPuntaje;//es la varable que guardara la informacionde todos los score

    //*****************************************

    public void AddScore (int value)
    {
        vida += value;//puntaje vida sera mas igual al valor
        crayolas += value;//puntaje crayolas sera mas igual al valor
        puntajeGoma += value;//puntaje gomas sera mas igual al valor
        puntajeTintero += value;//puntaje tintero sera mas igual al valor
        UpdateScore();//se manda a llamar el upsdate score

    }
    void UpdateScore()
    {
        vidaa.text = "Vida: " + vida;//la variable vida que es texto sera igual la palabra tintero más el vida del vida tipo int
        crayolaa.text = "Crayolas: " + crayolas;//la variable crayolas que es texto sera igual la palabra crayolas más el puntaje del crayolas tipo int
        gomaa.text = "Gomas: " + puntajeGoma;//la variable gomas que es texto sera igual la palabra gomas más el puntaje del gomas tipo int
        tinteroo.text = "Tinteros: " + puntajeTintero;//la variable tintero que es texto sera igual la palabra tintero más el puntaje del tintero tipo int
        
    }
    void Start()
    {               
        fisicasRB2D = GetComponent<Rigidbody2D>();////la variable fisicaRBD se asigna a el componente rgd2d
        spritePlayer = GetComponent<SpriteRenderer>();//la variable sprite player se asigna a el componente sprite renderer
        fuerzaSaltoPersonaje = 9.7f;//la variable fuerza de salto inicializa en nueve punto siete
        velocidadPersonaje = 2.0f;//la variable velodidad de personjae se inicializa en dos
        vida = 3;//la variable vida inicilaiza en tres
        crayolas = 0;//la varaible crayola inicializa en cero
        puntajeGoma = 0;//la varaible goma iniciliza en cero
        puntajeTintero = 0;//la varaible tintero inicializa en cero
        UpdateScore();//se manda a llamar al update score
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))//Sirve para indicarle que debe accionar en caso de presionar esa tecla

        {  
            Debug.Log(a);//inicializar en cero
            if (a<3)//si a es igual a 3
            {
                fisicasRB2D.AddForce(Vector2.up * fuerzaSaltoPersonaje, ForceMode2D.Impulse);//Es lo que se accionara cuando la tecla Space sea presionada, en este caso es el salto, tambien determina con que fuerza se hara
                Debug.Log(a);//devolver a 
                a = a + 1;//a es igual a a mas uno
            }
            
        }        

        if (Input.GetKey(KeyCode.RightArrow))//Sirve para indicarle que debe accionar en caso de presionar RightArrow
        {        
            fisicasRB2D.velocity = new Vector2(velocidadPersonaje, fisicasRB2D.velocity.y);//Es lo que se accionara cuando presione la tecla RightArrow, asi mimso la fuerza con la que debera moverse y en que dirección y snetido
       
        }

        if (Input.GetKey(KeyCode.LeftArrow))//Funciona para indicar que tecla accionara una acción en caso de ser seleccionada.
        {
            fisicasRB2D.velocity = new Vector2(-velocidadPersonaje, fisicasRB2D.velocity.y);//Es lo que se acciona cuando presionas la tecla, tambien hacía que direccion y sentido lo hara
        }

        if (Input.GetKey(KeyCode.DownArrow))//si no se pulsa niniguna tecla 
        {
            fuerzaSaltoPersonaje = 0;//la fuerza sera igual a cero
            if (Input.GetKey(KeyCode.Space))//si se aprieta la tecla espacio
            {
                gameObject.GetComponent<Collider2D>().enabled = false;//tendra una fuerza de salto
            }

        }
        else
        {
            fuerzaSaltoPersonaje = 5.0f;//la fuerza del salto sera 5
            gameObject.GetComponent<Collider2D>().enabled = true;//el game object se modificara en su collider 2d
        }


   

        if (vida <= 0)//Indicador de rango de vida, si vida es menor o igual a 0 

        {
            Destroy(this.gameObject);//este se destruira
        }


        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.248059f, 8.2f), Mathf.Clamp(transform.position.y, -3.59f, 49.4f), transform.position.z)//es el limite de movimiento que podra tener la plataforma;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        a = 0;//aqui se resetea el salto
    }




}// fin del cuerpo de la clase
