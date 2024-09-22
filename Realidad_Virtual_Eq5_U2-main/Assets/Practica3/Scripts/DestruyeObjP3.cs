using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DestruyeObjP3 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text_puntuacion;
    private int contador1; // Mantén la variable privada

    // Propiedad pública para obtener el valor de contador1
    public int Contador1 
    {
        get { return contador1; }
    }

    private void Start()
    {
        contador1 = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject objeto = other.gameObject;
        if (!objeto.CompareTag("NoRompible"))
        {
            contador1++;
            text_puntuacion.text = contador1.ToString();
            Destroy(objeto);
        }
    }
}
