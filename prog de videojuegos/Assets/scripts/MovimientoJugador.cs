using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento del jugador.

    private Rigidbody2D rb;

    private void Start()
    {
        // Obtén el componente Rigidbody2D del jugador.
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");


        Vector2 movimiento = new Vector2(movimientoHorizontal * velocidad, movimientoVertical * velocidad);


        rb.velocity = movimiento;
    }
}
  

