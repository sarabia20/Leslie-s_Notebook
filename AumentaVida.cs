//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Estructura de datos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para generar el movimiento y desaparición del enemigo. 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentaVida : MonoBehaviour
{//Inicio de clase
    //Area de declaracion*****************************************
    [SerializeField]
    PlayerControl playerPuntaje;
    public int scoreValue;


    [SerializeField]
    PlayerControl playerVida;

    ****************************************************************
    void Start()
    {              
        playerVida = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
        playerPuntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            playerPuntaje.vida++;
            playerPuntaje.AddScore(scoreValue);
            Destroy(this.gameObject);
        }
    }
}//fin de la clase
