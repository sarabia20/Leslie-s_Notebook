//Nombre del desarrollador: Sarabia Cruz Sayra Alondra.
//Asignatura: Estructura de datos.
//Descripción de usos de este codigo:
/*
Este script de ocupara para generar el movimiento del enemigo
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSeno : MonoBehaviour
{//Inicio de clase
  
  //++++++++++++Area para declarar variables***********************
           //Array   ID

    [SerializeField]
    Transform[] Mov;//es el componenete transfor  de una variable llamada movimiento


    [SerializeField]
    Vector3[] posicionInicial;//es la biblioteca de datos con posision inicial

    public float velocidad;//variable para la velocidad
    public float extension;//variable para la extención de datos
    public float velocidadRotacion;//es la variable para la rotacion y velocidad de la misma

    //***********************************************
   
   void Start()
    {
       
        posicionInicial = new Vector3[Mov.Length];//sera la pocision incial donde se encuentra el componente de la nueva sierra

        for (int i = 0; i < Mov.Length; i++)//es para la cantidad de movimiento de la sierra basandose en su posicion inicial
        {
            posicionInicial[i] = Mov[i].position;//la posision inicial sera igual a la posision de la sierra
        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 senoPos = new Vector3(Mathf.Sin(Time.time * velocidad) * extension,0,0);//es para el movimiento sobre x, tomando en cuenta la velocidad 

        for (int i = 0; i < Mov.Length; i++)//tomando en cuenta la extencion de sierra 
        {
            Mov[i].position = posicionInicial[i] + senoPos;//tomando en cuenta su posision incial se sumara el seno
            velocidadRotacion = Random.Range(2.5f,10);//con un rango de rotacion de entre 90 y 180°
            Mov[i].Rotate(Vector3.forward * velocidadRotacion);//es la sierra rotada por la velocidad de rotación 
        }
        

    }
}//Fin de la l¿clase
