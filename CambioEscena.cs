//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Estructura de datos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para generar el cambio de escena.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{//Inicio de clase
    //+++++++área para declarar variables++++++
    [SerializeField]
    PlayerControl playerPuntaje;//manda a llamar las variables de esta varable de su script original
    [Tooltip("Esta variable me ayuda a definir el numero de escena a cargar.")]//da para que sirve esa parte
    public int numeroEscena;//es una variable publica con int que almacenara escenas 

    //*****************************************

    void Start()
    {
        playerPuntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();//player puntaje es igual a buscar un objeto con el tag Player y a su comoponenete player control
        playerPuntaje.crayolas = 0;//el player puntaje mandara a traer a la variable de crayolas y esta es igual a cero
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Player")//si un objeto con el tag player colisiona con el dueño del script
       {
            if (playerPuntaje.crayolas ==3 )// si el player puntaje con la variable de crayola es igual a 3 
            {
                SceneManager.LoadScene(numeroEscena);//cambia de escena 
            }
                
       }
        
    }

}//Fin de la clase
