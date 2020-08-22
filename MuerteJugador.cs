//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Estructura de datos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para generar la baja de vidas del jugador.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteJugador : MonoBehaviour
{
    [SerializeField]
    float cronometro = 0.0f;//variable que guarda la variable que contendra la información de cronometro

    [SerializeField]
    PlayerControl playerVida;//manda a llamar la variable que contiene vida 
    Rigidbody2D fisicasRB2D;//el componente RBD se guardara en las fisicas rbd
    public float fuerzaSaltoPersonaje;//

    [SerializeField]
    PlayerControl playerPuntaje;//es la variable que guarda la informacion y la manda a llmara de su script ptincipal 
    public int scoreValue;//

    void Start()
    {
        playerPuntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();//player puntaje es igual a buscar un objeto con el tag Player y a su comoponenete player control

    }

    private void OnCollisionEnter2D(Collision2D collision)//Evento o mecanica nucleo
    {
   
        if (collision.gameObject.tag == "Player")//suma la vida
        {
            playerPuntaje.vida--;//agrega el valor a score
            playerPuntaje.AddScore(scoreValue);//y eliminalo
        }
    }
    
}//fin de la clase
