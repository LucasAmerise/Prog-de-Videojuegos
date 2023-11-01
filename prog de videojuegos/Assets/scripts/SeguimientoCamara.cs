using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    
        public Transform objetivo; // El objeto que la cámara debe seguir.
        public float suavidad = 5.0f; // Controla la suavidad del seguimiento.

        private void Update()
        {
            if (objetivo == null)
                return;

            Vector3 nuevaPosicion = new Vector3(objetivo.position.x, objetivo.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, nuevaPosicion, suavidad * Time.deltaTime);
        }
    }
