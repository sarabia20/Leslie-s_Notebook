//Nombre del desarrollador: Sarabia Cruz Sayra Alondra.
//Asignatura: Estructura de datos.
//Descripción de usos de este codigo:
/*
Este script funcionara para detectar el piso
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{//Inicio de clase

    //+++++++área para declarar variables++++++
    public static bool isGround;

    //*****************************************
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGround = true;
    }

    
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGround = false;
    }
}//Fin de la clase
