using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InicioJuego : MonoBehaviour
{ //Texto de "Pulsa ESPACIO para jugar"
    public TextMeshProUGUI textoParaBorrar;
    //variable para que el juego inicie pausado
    private bool isPaused = true;

    void Start()
    {
        Time.timeScale = 0f; 
    }

    void Update()
    {
     //indica que cuando el juego este pausado y se le de al espacio el juego inicie
        if (isPaused && Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = false;
            Time.timeScale = 1f;

          
            textoParaBorrar.text = "";
        }
    }

    public void StartGame()
    {
        //indica que cuando se despause el juego inicie la escena
        if (!isPaused) return;

    
        SceneManager.LoadScene("Juego");

  
        isPaused = false;
        Time.timeScale = 1f;
    }
}
