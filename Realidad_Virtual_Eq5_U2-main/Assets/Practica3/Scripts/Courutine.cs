using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Courutine : MonoBehaviour
{
    [SerializeField] ChangeSceneScore auxiliar;
    [SerializeField] DestruyeObjP3 aux_cont_enemigos;
    [SerializeField] TextMeshProUGUI text_contador;
    
    int cont;

    // Start is called before the first frame update
    void Start()
    {
        cont = 40; 
        StartCoroutine("coroutine_contador");
    }

    // Update is called once per frame
    IEnumerator coroutine_contador()
    {
        while (cont > 0)
        {
            cont--;
            text_contador.text = cont.ToString();
            yield return new WaitForSeconds(1f);
        }

        // Asumiendo que contador1 es público o tienes un getter para acceder
        int score = aux_cont_enemigos.Contador1;
        
        // Llama al método cambioEscena en auxiliar
        auxiliar.cambioEscena(2, score); // Escena de fin de juego
    }
}
