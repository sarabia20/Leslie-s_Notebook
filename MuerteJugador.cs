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
    float cronometro = 0.0f;

    [SerializeField]
    PlayerControl playerVida;
    //EL tipo dato  nombre de variable
    Rigidbody2D fisicasRB2D;
    // al declarar una variable como publica esta se podra visulizar en el inspector
    public float fuerzaSaltoPersonaje;

    [SerializeField]
    PlayerControl playerPuntaje;
    public int scoreValue;

    void Start()
    {
        playerPuntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();

    }

    private void OnCollisionEnter2D(Collision2D collision)//Evento o mecanica nucleo
    {
   
        if (collision.gameObject.tag == "Player")
        {
            playerPuntaje.vida--;
            playerPuntaje.AddScore(scoreValue);
        }
    }
    
}
