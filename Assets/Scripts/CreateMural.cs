using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.XR.ARFoundation.Samples;
using System;
public class CreateMural : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject MemorialChosed;
    MemorialChosed memorial;
    GameObject clone;
   public PlaceOnPlane plane;

    int o = 0;

    private void Awake()
    {
        MemorialChosed = GameObject.Find("MemorialChosed");
        memorial = MemorialChosed.GetComponent<MemorialChosed>();

        o = 0;
    }

    void Start()
    {
        if (memorial.fakeMemorial)
        {
            fakeMessage();
            clone = GameObject.Find("fakeMessage(Clone)");
        }

    }

    private void Update()
    {
        try { 
        if (clone.activeInHierarchy == false && memorial.fakeMemorial)
        {
            fakes();
        }
        }
        catch (NullReferenceException)
        {
            if (memorial.fakeMemorial == false)
            {
                real();
            }
        }

    }

    public void fakeMessage()
    {
        GameObject x = (GameObject)Resources.Load("fakeMessage");
        Instantiate(x);
    }

    public void fakes()
    {
        if (o == 0)
        {
            if (memorial.Lola)
            {
                var x = Resources.Load("Fake Lola");           
                Instantiate(x);
                o++;
            }
            else if (memorial.Guido)
            {
                var x = Resources.Load("Fake Guido");
                Instantiate(x);
                o++;
            }
            else if (memorial.Martin)
            {
                var x = Resources.Load("Fake Martin");
                Instantiate(x);
                o++;
            }
        }
    }

    public void real()
    {
        if (o == 0)
        {
            if (memorial.Lola)
            {
                var x = Resources.Load("Lola");
                plane.placedPrefab = (GameObject)x;
                o++;
            }
            else if (memorial.Guido)
            {
                var x = Resources.Load("Guido");
                plane.placedPrefab = (GameObject)x;
                o++;
            }
            else if (memorial.Martin)
            {
                var x = Resources.Load("Martin");
                plane.placedPrefab = (GameObject)x;
                o++;
            }
        }
    }

}
