using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S7_Contador : MonoBehaviour
{
    [SerializeField] ChangeScene auxiliar;
    [SerializeField] S8_DestruyeObj aux_cont_enemigos;
    int cont;
    [SerializeField] TextMeshProUGUI text_contador;
    // Start is called before the first frame update
    void Start()
    {
    cont = 10; 
    StartCoroutine("coroutine_contador");
    }

    // Update is called once per frame
    IEnumerator coroutine_contador(){
        while(cont>0){
            cont--;
            text_contador.text= cont.ToString();
            yield return new WaitForSeconds(1f);
        }

        int score = aux_cont_enemigos.contador;
        auxiliar.cambioEscena(2, score);//Escena de fin de juego
    }
}