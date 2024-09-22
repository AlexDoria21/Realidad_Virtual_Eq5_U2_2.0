using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S8_DestruyeObj : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text_puntuacion;
    public int contador;
    
    private void Start(){
        contador=0;
    }
    private void    OnCollisionEnter(Collision other){
        GameObject objeto = other.gameObject;
        if (!objeto.CompareTag("NoRompible")){
            contador++;
            text_puntuacion.text = contador.ToString();
            Destroy(objeto);
        }
    }    
}
