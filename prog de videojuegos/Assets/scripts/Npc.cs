using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public Transform[] waypoints; // Arreglo de transformadores de los waypoints
    public float moveSpeed = 3.0f; // Velocidad de movimiento
    public float stoppingDistance = 1.0f; // Distancia de detención
    private int currentWaypointIndex = 0; // Índice del waypoint actual

    void Start()
    {
        if (waypoints.Length == 0)
        {
            Debug.LogWarning("No se han asignado waypoints. Asegúrate de asignar los waypoints en el inspector.");
        }
    }

    void Update()
    {
        if (currentWaypointIndex < waypoints.Length)
        {
            Transform currentWaypoint = waypoints[currentWaypointIndex];

            Vector3 direction = currentWaypoint.position - transform.position;
            direction.z = 0; 
     
            if (direction.magnitude <= stoppingDistance)
            {
               
                currentWaypointIndex++;
            }
            else
            {
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            }
        }
    }
}