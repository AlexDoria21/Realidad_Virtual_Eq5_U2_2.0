using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_DestruyeObj : MonoBehaviour
{   
    private void    OnCollisionEnter(Collision other){
        GameObject objeto = other.gameObject;
        if (!objeto.CompareTag("NoRompible")){
            Destroy(objeto);
        }
    }    
    // Start is called before the first frame update
}