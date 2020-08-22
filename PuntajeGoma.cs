//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Estructura de datos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para que en la pantalla se visualise el contador de la goma al colisionar con el.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntajeGoma : MonoBehaviour
{//Incio de la clase
    //area para declarar****************************************************
    [SerializeField]
    PlayerControl playerPuntaje;
    public int scoreValue;
    
    //*********************************************************************

    // Start is called before the first frame update
    void Start()
    {
       playerPuntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();//player puntaje es igual a buscar un objeto con el tag Player y a su comoponenete player control

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")//si un objeto con el tag player colisona con este objeto
        {
        {
            playerPuntaje.puntajeGoma++;//suma la vida
            playerPuntaje.AddScore(scoreValue);//agrega el valor a score
            Destroy(this.gameObject);//y eliminalo
        }
    }
}
