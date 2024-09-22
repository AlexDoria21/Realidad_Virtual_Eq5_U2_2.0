using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorP3 : MonoBehaviour
{
    int cont;
    [SerializeField] TextMeshProUGUI text_contador;
    // Start is called before the first frame update
    void Start()
    {
    cont = 40; 
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