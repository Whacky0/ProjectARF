using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControlBotones : MonoBehaviour
{

     public GameObject volveralmapa;
    
    // Start is called before the first frame update
    void Start()
    {
        
        volveralmapa.SetActive(true);
    }

     public void volveratras()
    {
        SceneManager.LoadScene("Mapa");
    }

  
  }