using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    
        public Transform objetivo; // El objeto que la cámara debe seguir, en este caso el jugador
        public float suavidad = 5.0f; // Controla la suavidad con la que sigue al jugador

        private void Update()
        {
            if (objetivo == null)
                return;
            //Traslada la posicion hasta donde este el jugador

            Vector3 nuevaPosicion = new Vector3(objetivo.position.x, objetivo.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, nuevaPosicion, suavidad * Time.deltaTime);
        }
    }
