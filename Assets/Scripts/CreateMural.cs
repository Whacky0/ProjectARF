using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMural : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject MemorialChosed;
    MemorialChosed memorial;

    private void Awake()
    {
        MemorialChosed = GameObject.Find("MemorialChosed");
        memorial = MemorialChosed.GetComponent<MemorialChosed>();
    }

    void Start()
    {
        if (memorial.Lola)
        {
            lolaMural();
        }
        else if (memorial.Guido)
        {
            guidoMural();
        }
        else if (memorial.Martin)
        {
            martinMural();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void guidoMural()
    {

        if (memorial.fakeMemorial) 
        { 
        
        
        }
        else
        {
            var x = Resources.Load("Guido");
            Instantiate(x);
        }


    }

    void martinMural()
    {

        if (memorial.fakeMemorial)
        {


        }
        else
        {
            var x = Resources.Load("Martin");
            Instantiate(x);
        }

    }
    void lolaMural()
    {

        if (memorial.fakeMemorial)
        {


        }
        else
        {
            var x = Resources.Load("Lola");
            Instantiate(x);
        }
    }
}
