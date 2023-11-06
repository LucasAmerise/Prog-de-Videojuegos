using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena2 : MonoBehaviour
{
    //instancia la variable de que el jugador pasa por el Weapoint
    private bool firstPass = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si el Jugador paso por el Weapoint
        if (collision.gameObject.name == "Jugador")
        {
            if (firstPass)
            {
                // Si es la primera pasada, marca la primera pasada como completa
                firstPass = false;
            }
            //si es la segunda pasada, cambia de escena 
            else
            {
 
                SceneManager.LoadScene("Escena2");
            }
        }
    }
}
