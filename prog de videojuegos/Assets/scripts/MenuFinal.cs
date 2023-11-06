using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinal : MonoBehaviour
{
    //Indica que al darle al boton, cambia a la escena de menu
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");

    }
}

