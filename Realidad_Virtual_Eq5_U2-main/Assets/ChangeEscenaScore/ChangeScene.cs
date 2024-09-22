using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI valor_score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int index_scene_active = SceneManager.GetActiveScene().buildIndex;
        if ( index_scene_active== 0 ){//INICIO

        if(Input.GetKeyDown(KeyCode.Space)){
        SceneManager.LoadScene(1); //ESCENA DEL JUEGO
        }  
        }
        else if (index_scene_active==1){//JUEGO

        }
        else{//ESCENA FINAL
        valor_score.text = PlayerPrefs.GetInt("Puntaje", 0).ToString();

        }
    }
    public void cambioEscena(int index){
        SceneManager.LoadScene(index);
    }
    
    public void cambioEscena(int index, int puntaje ){
        PlayerPrefs.SetInt("Puntaje", puntaje);//Almacena el puntaje en memoria
        cambioEscena(index);
    }
    

}
