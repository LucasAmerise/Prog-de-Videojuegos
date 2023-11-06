using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

        //instancia que todas las posiciones estan en falso asi que inicia en Idle
        animator.SetBool("isLeft", false);
        animator.SetBool("isUp", false);
        animator.SetBool("isDown", false);
    }

    private void Update()
    {
        //toma las variables de Horizontal y Vertical para poder usar las Animaciones
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Indca que si Horizontal va en negativo se ponga la animacion "Izquierda"
        animator.SetBool("isLeft", horizontalInput < 0);
        //Indca que si Vertical va en positivo se ponga la animacion "Arriba"
        animator.SetBool("isUp", verticalInput > 0);
        //Indca que si Vertical va en negativo se ponga la animacion "Abajo"
        animator.SetBool("isDown", verticalInput < 0);
    }
}