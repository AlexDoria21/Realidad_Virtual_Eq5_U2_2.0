using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestruyeObj2 : MonoBehaviour

{
    [SerializeField] TextMeshProUGUI text_puntuacion;
    private int contadorTipo2 = 0;
    public string tagTipo2 = "Azul";  // El tag que debe tener el objeto para ser destruido

    private void Start()
    {
        // Inicializa la puntuación en la UI
        ActualizarPuntuacion();
    }

    private void OnCollisionEnter(Collision other)
    {
        // Comprueba si el objeto colisionado tiene el tag especificado para Tipo 2
        if (other.gameObject.CompareTag(tagTipo2))
        {
            // Aumenta el contador
            contadorTipo2++;

            // Actualiza el texto de la puntuación
            ActualizarPuntuacion();

            // Destruye el objeto colisionado
            Destroy(other.gameObject);
        }
    }

    private void ActualizarPuntuacion()
    {
        // Actualiza el texto de la puntuación en la UI
        text_puntuacion.text = contadorTipo2.ToString();
    }
}