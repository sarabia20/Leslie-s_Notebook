//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Estructura de datos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para que en la pantalla se visualise el contador de vida al sumar o restar la vida.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentaVida : MonoBehaviour
{//Inicio de clase
    //Area de declaracion*****************************************
    [SerializeField]
    PlayerControl playerPuntaje; //Manda a llamar el componente del player control que contiene datos sobre que debe mostrar
    
    public int scoreValue;//almacenara el dato de tipo int para el score 

    [SerializeField]
    PlayerControl playerVida;////Manda a llamar el componente del player control que contiene datos sobre la vida para este script 

    ****************************************************************
    void Start()
    {              
        playerVida = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();//player vida es igual a buscar un game object que tenga el tag Player y ve a su componente Player control
        playerPuntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();//player puntaje es igual a buscar un objeto con el tag Player y a su comoponenete player control


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")//si un objeto con el tag player colisona con este objeto
        {
            playerPuntaje.vida++;//suma la vida
            playerPuntaje.AddScore(scoreValue);//agrega el valor a score
            Destroy(this.gameObject);//y eliminalo
        }
    }
}//fin de la clase
