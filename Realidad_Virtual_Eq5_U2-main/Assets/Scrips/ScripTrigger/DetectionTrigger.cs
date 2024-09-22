using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectionTrigger : MonoBehaviour
{
    Renderer rend;
    Material material;
    Material m_material;

    [SerializeField] GameObject plancha_resultado;

    private void Start()
    {
        // Obtén el Renderer una sola vez
        rend = GetComponent<Renderer>();

        // Usar sharedMaterial para evitar duplicados de material
        material = rend.sharedMaterial;

        // Cachear el material original de plancha_resultado
        m_material = plancha_resultado.GetComponent<Renderer>().sharedMaterial;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("T. Enter: " + other.gameObject.name);
        // Actualiza el material cuando entra el objeto en la zona de trigger
        plancha_resultado.GetComponent<Renderer>().sharedMaterial = material;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("T. Stay: " + other.gameObject.name);
        // No es necesario reasignar material si no ha cambiado
        plancha_resultado.GetComponent<Renderer>().sharedMaterial = material;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("T. Exit: " + other.gameObject.name);
        // Restaura el material original cuando el objeto sale del trigger
        plancha_resultado.GetComponent<Renderer>().sharedMaterial = m_material;
    }
}
