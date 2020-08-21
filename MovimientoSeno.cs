using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSeno : MonoBehaviour
{

           //Array   ID

    [SerializeField]
    Transform[] Mov;

    [SerializeField]
    Vector3[] posicionInicial;

    public float velocidad;
    public float extension;
    public float velocidadRotacion;

    // Start is called before the first frame update
    void Start()
    {
       
        posicionInicial = new Vector3[Mov.Length];

        for (int i = 0; i < Mov.Length; i++)
        {
            posicionInicial[i] = Mov[i].position;
        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 senoPos = new Vector3(Mathf.Sin(Time.time * velocidad) * extension,0,0);

        for (int i = 0; i < Mov.Length; i++)
        {
            Mov[i].position = posicionInicial[i] + senoPos;

            velocidadRotacion = Random.Range(2.5f,10);
            Mov[i].Rotate(Vector3.forward * velocidadRotacion);
        }
        

    }
}
