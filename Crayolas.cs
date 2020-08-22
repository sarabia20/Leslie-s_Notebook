using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crayolas : MonoBehaviour
{
    [SerializeField]
    PlayerControl playerPuntaje;//Manda a llamar el componente del player control que contiene datos sobre que debe mostrar
    public int scoreValue;//almacenara el dato de tipo int para el score 


    // Start is called before the first frame update
    void Start()
    {
        playerPuntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();//player puntaje es igual a buscar un objeto con el tag Player y a su comoponenete player control
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")//si un objeto con el tag player colisona con este objeto
        {
            playerPuntaje.crayolas++;//suma la vida
            playerPuntaje.AddScore(scoreValue);//agrega el valor a score
            Destroy(this.gameObject);//y eliminalo
        }
    }
}
