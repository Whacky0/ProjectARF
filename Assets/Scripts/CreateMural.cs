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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void guidoMural()
    {
        //instancia el mural

    }
    void lolaMural()
    {
        // instancia el mural
    }
}
