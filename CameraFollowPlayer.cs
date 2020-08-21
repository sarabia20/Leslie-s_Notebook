﻿//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Estructura de datos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para generar el segumiento de la camara del personaje y del enemigo.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{//Inicio de clase

    //+++++++área para declarar variables++++++
    public Transform target;
    public Vector3 puntoInicial;


    //*****************************************
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, 0f, 0f), Mathf.Clamp(target.position.y, 0f, 44.525f), transform.position.z);
        
    }
}//Fin de la clase
