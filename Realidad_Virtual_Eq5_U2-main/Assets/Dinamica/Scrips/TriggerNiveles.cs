using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerNiveles : MonoBehaviour
{
    // Método para cargar la siguiente escena
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Método que llama cuando el jugador cae (Game Over)
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    // Método que se usa en triggers para avanzar niveles
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().name == "Nivel1")
            {
                LoadScene("Nivel2");
            }
            else if (SceneManager.GetActiveScene().name == "Nivel2")
            {
                LoadScene("Win");
            }
        }
    }
}
