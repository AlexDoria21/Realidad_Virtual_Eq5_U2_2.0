using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_caidaP3 : MonoBehaviour
{
    [SerializeField] Transform spawn;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float valor_y;
        valor_y = transform.position.y;

        if (valor_y < 0){
            transform.position = spawn.position;
        }

    }
}
