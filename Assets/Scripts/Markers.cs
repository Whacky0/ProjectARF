using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;

public class Markers : MonoBehaviour
{
    AbstractMap _map;
    public GameObject[] gameObjects= new GameObject[3];
    public Vector2d[] locations = new Vector2d[3];


    // Start is called before the first frame update
    void Start()
    {
        _map = GameObject.FindGameObjectWithTag("Map").GetComponent<AbstractMap>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void customMarkers()
    {
        //_map.
    }
}
