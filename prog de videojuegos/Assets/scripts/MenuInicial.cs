using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    //Indica que al darle al boton cambia de escena a "JUEGO"
 public void Jugar()
    {
        SceneManager.LoadScene("Juego");

    }
}
