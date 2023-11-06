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
        Time.timeScale = 0f; 
    }

    void Update()
    {
     
        if (isPaused && Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = false;
            Time.timeScale = 1f;

          
            textoParaBorrar.text = "";
        }
    }

    public void StartGame()
    {
        if (!isPaused) return;

    
        SceneManager.LoadScene("Juego");

  
        isPaused = false;
        Time.timeScale = 1f;
    }
}
