using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDialogoColor : MonoBehaviour
{
    // Este método se llama cuando el jugador entra en un trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entra en el trigger es el jugador
        if (other.CompareTag("Player"))
        {
            // Dependiendo del nombre o color del objeto, mostrar un mensaje diferente
            if (gameObject.name == "ROJO")
            {
                Debug.Log("El jugador ha tocado el trigger ROJO.");
            }
            else if (gameObject.name == "BLANCO")
            {
                Debug.Log("El jugador ha tocado el trigger BLANCO.");
            }
            else if (gameObject.name == "NEGRO")
            {
                Debug.Log("El jugador ha tocado el trigger NEGRO.");
            }
            else if (gameObject.name == "NARANJA")
            {
                Debug.Log("El jugador ha tocado el trigger NARANJA.");
            }
        }
    }
}