using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DestruyeObjj : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text_puntuacion;
    int contador;
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