using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3_Rotacion_forma1 : MonoBehaviour
{
    [SerializeField] float velocidad =10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angulos = 5 * Time.deltaTime * velocidad;
                      // x     y     z
        transform.Rotate(0, angulos, 0);
    }
}
