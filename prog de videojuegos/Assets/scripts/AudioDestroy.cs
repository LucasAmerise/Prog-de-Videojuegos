using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDestroy : MonoBehaviour
{
    //instancia la clase AudioDestroy como estatica
    private static AudioDestroy instance;

    void Awake()
    {
        //if hace que cuando la cancion inicie no se destruya al cambiar las escenas
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
