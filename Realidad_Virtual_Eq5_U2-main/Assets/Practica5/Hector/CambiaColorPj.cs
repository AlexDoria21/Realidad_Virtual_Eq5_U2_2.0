using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColorPj : MonoBehaviour
{
    public Color nuevoColor = Color.red;  // Color al que queremos cambiar el jugador

    private Color colorOriginal;  // Para guardar el color original del jugador

    private void Start()
    {
        // Guardamos el color original del jugador cuando empieza el juego (opcional, si quieres cambiar el color al inicio)
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verificamos si el objeto que entra en el trigger es el jugador
        if (other.CompareTag("Player"))
        {
            // Obtenemos el Renderer del jugador
            Renderer jugadorRenderer = other.GetComponent<Renderer>();

            if (jugadorRenderer != null)
            {
                // Guardamos el color original del jugador antes de cambiarlo
                colorOriginal = jugadorRenderer.material.color;

                // Cambiamos el color del jugador al nuevo color
                jugadorRenderer.material.color = nuevoColor;

                Debug.Log("El color del jugador ha cambiado a: " + nuevoColor);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Cuando el jugador salga del trigger, volverá a su color original
        if (other.CompareTag("Player"))
        {
            Renderer jugadorRenderer = other.GetComponent<Renderer>();

            if (jugadorRenderer != null)
            {
                // Restablecemos el color original
                jugadorRenderer.material.color = colorOriginal;

                Debug.Log("El color del jugador ha vuelto a su estado original.");
            }
        }
    }
}