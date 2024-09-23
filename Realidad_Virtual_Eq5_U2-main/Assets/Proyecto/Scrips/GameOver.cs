using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Umbral para detectar cuándo el jugador ha caído
    public float fallThreshold = 0.0f;

    // Nombre de la escena de Game Over
    public string gameOverSceneName = "GameOver";

    // Update se llama una vez por frame
    void Update()
    {
        // Verificamos si la posición en Y del jugador es menor al umbral (en este caso 0)
        if (transform.position.y < fallThreshold)
        {
            // Cargar la escena de Game Over
            SceneManager.LoadScene(gameOverSceneName);
        }
    }
}
