using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5.0f;
    private int currentWaypointIndex = 0;

    void Start()
    {
        // Inicializa el arreglo de waypoints buscando GameObjects con nombres "WP" seguido de n�meros.
        waypoints = new Transform[17]; // Ajusta el tama�o seg�n la cantidad de waypoints que tengas.

        for (int i = 0; i < waypoints.Length; i++)
        {
            Transform waypoint = GameObject.Find("WP" + (i + 1)).transform;
            if (waypoint != null)
            {
                waypoints[i] = waypoint;
            }
        }
    }

    void Update()
    {
        if (currentWaypointIndex < waypoints.Length)
        {
            // Calcula la direcci�n hacia el waypoint actual.
            Vector2 targetPosition = waypoints[currentWaypointIndex].position;
            Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
            Vector2 direction = (targetPosition - currentPosition).normalized;

            // Mueve el NPC hacia el waypoint.
            transform.Translate(direction * speed * Time.deltaTime);

            // Si el NPC est� lo suficientemente cerca del waypoint, pasa al siguiente.
            if (Vector2.Distance(currentPosition, targetPosition) < 0.1f)
            {
                currentWaypointIndex++;

                // Si llegamos al �ltimo waypoint, reiniciamos el �ndice para hacer un bucle.
                if (currentWaypointIndex >= waypoints.Length)
                {
                    currentWaypointIndex = 0;
                }
            }
        }
    }
}