using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntajeGoma : MonoBehaviour
{
    
    [SerializeField]
    PlayerControl playerPuntaje;
    public int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
       playerPuntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            playerPuntaje.puntajeGoma++;
            playerPuntaje.AddScore(scoreValue);
            Destroy(this.gameObject);
        }
    }
}
