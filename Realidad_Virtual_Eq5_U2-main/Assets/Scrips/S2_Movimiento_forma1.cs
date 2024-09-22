using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2_Movimiento_forma1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    float constante_velocidad = 5;
        if(Input.GetKey(KeyCode.W)){
            transform.position += constante_velocidad * Time.deltaTime * transform.forward;
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position += constante_velocidad * -1 * Time.deltaTime * transform.forward;
        }   
    }
}
