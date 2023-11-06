using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public Transform[] waypoints; // Arreglo de transformadores de los waypoints
    public float moveSpeed = 3.0f; // Velocidad de movimiento
    public float stoppingDistance = 1.0f; // Distancia de detención
    private int currentWaypointIndex = 0; // Índice del waypoint actual
    void Update()
    {
        //Indica que si el Weapoint actual en el que esta es menor al siguiente, tiene que trasladarse al que sigue
        if (currentWaypointIndex < waypoints.Length)
        {
            Transform currentWaypoint = waypoints[currentWaypointIndex];
            //indica la direccion del objetivo que debe seguir el NPC
            Vector3 direction = currentWaypoint.position - transform.position;
            direction.z = 0; 
     //Suma un Weapoint al weapoint actual
            if (direction.magnitude <= stoppingDistance)
            {
               
                currentWaypointIndex++;
            }
            //si no llego al weapoint actual se traslada hasta el
            else
            {
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            }
        }
    }
}