using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPuerta : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = "1";  // Nombre de la escena que cargará la puerta 1

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player ha entrado en la Puerta Cargando: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
        
    }
}
