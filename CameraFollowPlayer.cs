//Nombre del desarrollador: Sarabia Cruz Sayra Alondra
//Asignatura: Estructura de datos
//Descripcion del usos de este codigo:
/*
Este script se utilizara para generar el segumiento de la camara del personaje
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{//Inicio de clase

    //+++++++área para declarar variables++++++
    public Transform target;//es una referencia al componente trasnform de un objeto
    public Vector3 puntoInicial;//es una variable donde se va almacenar la cámara
    //*****************************************
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, 0f, 0f), Mathf.Clamp(target.position.y, 0f, 44.525f), transform.position.z);//es para delimitar hasta que punto puede extender el seguimineto de la cámara en su eje x y
        
    }
}//Fin de la clase
