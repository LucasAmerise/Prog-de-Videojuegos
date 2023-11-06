using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena2 : MonoBehaviour
{
    private bool firstPass = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si el objeto que colisionó es el "Jugador".
        if (collision.gameObject.name == "Jugador")
        {
            if (firstPass)
            {
                // Si es la primera pasada, marca la primera pasada como completa.
                firstPass = false;
            }
            else
            {
 
                SceneManager.LoadScene("Escena2");
            }
        }
    }
}
