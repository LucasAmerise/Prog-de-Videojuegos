using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    //Añadido de efectos de sonido
    private AudioSource audioSource;
    //Instancia la velocidad del Jugador
    public float velocidad = 5.0f; 
    //Instancia el Rigibody2D
    private Rigidbody2D rb;

    private void Start()
    {
        //Obtiene el rigybody del Jugador
        rb = GetComponent<Rigidbody2D>();
        //Obtiene el sonido colocado en el Audio Source del jugador
        audioSource= rb.GetComponent<AudioSource>();
    }

    private void Update()
    {
        //variables de movimiento tanto orizontal como vertical
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        //movimiento del jugador
        Vector2 movimiento = new Vector2(movimientoHorizontal * velocidad, movimientoVertical * velocidad);

        //Indica que la velocidad del rigibody es el movimiento
        rb.velocity = movimiento;
        //Indica que cuando el Jugador se mueva inicie el movimiento y cuando se detenga pare
        if (movimiento != Vector2.zero)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else audioSource.Stop();
    }
}
  

