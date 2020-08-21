//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Estructura de datos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para generar el movimiento del enemigo de manera vertical.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersecuciónLinea : MonoBehaviour
{//Inicio de clase

    //+++++++área para declarar variables++++++
    public Transform target; 
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Objetivo").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, 0.4f*Time.deltaTime);
    }
}//Fin de la clase
