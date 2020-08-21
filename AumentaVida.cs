using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentaVida : MonoBehaviour
{
    [SerializeField]
    PlayerControl playerPuntaje;
    public int scoreValue;


    [SerializeField]
    PlayerControl playerVida;

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
}
