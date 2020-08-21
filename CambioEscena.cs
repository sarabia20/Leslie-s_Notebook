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
    [SerializeField]
    PlayerControl playerPuntaje;


    //+++++++área para declarar variables++++++
    [Tooltip("Esta variable me ayuda a definir el numero de escena a cargar.")]
    public int numeroEscena;

    //*****************************************

    void Start()
    {
        playerPuntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
        playerPuntaje.crayolas = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Player")
       {
            if (playerPuntaje.crayolas ==3 )
            {
                SceneManager.LoadScene(numeroEscena);
            }
                
       }
        
    }

}//Fin de la clase
