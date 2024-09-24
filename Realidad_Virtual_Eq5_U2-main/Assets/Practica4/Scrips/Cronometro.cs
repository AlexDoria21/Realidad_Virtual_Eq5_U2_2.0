using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    

public class Cronometro : MonoBehaviour
{
    int cont;
    [SerializeField] TextMeshProUGUI text_contador;
    // Start is called before the first frame update
    void Start()
    {
    cont = 10; 
    StartCoroutine(coroutine_contador());
    }

    // Update is called once per frame
    IEnumerator coroutine_contador(){
        while(cont>0){
            cont--;
            text_contador.text= cont.ToString();
            yield return new WaitForSeconds(0.5f);
        }
    }
}