using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    //instancia la variable de que el jugador pasa por el Weapoint
    private bool firstPass = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si el Jugador pasa por el Weapoint
        if (collision.gameObject.name == "Jugador")
        {
            if (firstPass)
            {
                // Si es la primera pasada, marca la primera pasada como completa
                firstPass = false;
            }
            //Si es la segunda pasada, cambia de escena a "Final"
            else
            {

                SceneManager.LoadScene("Final");
            }
        }
    }
}