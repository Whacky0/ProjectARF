using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControlFake : MonoBehaviour
{

    public GameObject advertencia;
    public GameObject volver;
    public GameObject continuar;


    // Start is called before the first frame update
    void Start()
    {
        advertencia.SetActive(true);
        volver.SetActive(true);
        continuar.SetActive(true);
    }

    public void volveramapa()
    {
        SceneManager.LoadScene("Mapa");

    }

    public void continuaralfake()
    {
        advertencia.SetActive(false);
        volver.SetActive(false);
        continuar.SetActive(false);
    }


  }