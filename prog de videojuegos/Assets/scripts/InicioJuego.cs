using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InicioJuego : MonoBehaviour
{
    public TextMeshProUGUI textoParaBorrar;
    private bool isPaused = true;

    void Start()
    {
        Time.timeScale = 0f; // Iniciar el juego pausado
    }

    void Update()
    {
        // Verificar si se presiona la tecla de espacio para quitar la pausa y borrar el texto
        if (isPaused && Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = false;
            Time.timeScale = 1f; // Reanudar el tiempo

            // Borra el texto
            textoParaBorrar.text = "";
        }
    }

    public void StartGame()
    {
        if (!isPaused) return;

        // Cargar la escena del juego
        SceneManager.LoadScene("Juego");

        // Desactivar la pausa cuando la escena del juego esté cargada
        isPaused = false;
        Time.timeScale = 1f;
    }
}
