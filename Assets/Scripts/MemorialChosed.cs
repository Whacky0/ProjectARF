using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Location;
using Mapbox.Examples;
using UnityEngine.SceneManagement;
public class MemorialChosed : MonoBehaviour
{
    MemorialChosed instance;
    public string coordenadas;
    public bool Guido;
    public bool Lola;
    public bool Martin;

    public ImmediatePositionWithLocationProvider locationProvider;
    public ILocationProvider location;

    public bool fakeMemorial;

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else { 
        DontDestroyOnLoad(this);
        }
        DontDestroyOnLoad(this);
        Guido = false;
        Lola = false;
        Martin = false;
        fakeMemorial = false;

    }

    private void Update()
    {
        location = locationProvider.LocationProvider;

    }

    public void GuidoMural()
    {
        Guido = true;
        coordenadas = "-34.61761077880108, -58.43419318543805";
        var loc=location.CurrentLocation;
        var x = loc.LatitudeLongitude.x;
        var y = loc.LatitudeLongitude.y;

        fakeMemorial = false;
        SceneManager.LoadScene("Memoriales");

        //if (x <= -34.616589 && x >= -34.618968 && y <= -58.432249 && y >= -58.434540)
        //{
        //    fakeMemorial = false;
        //    SceneManager.LoadScene("Memoriales");
        //}
        //else
        //{
        //    fakeMemorial = true;
        //    SceneManager.LoadScene("Memoriales");
        //}
    }

    public void LolaMural()
    {
        Lola = true;
        coordenadas = "-34.61686412415361, -58.43276156853936";
        var loc = location.CurrentLocation;
        var x = loc.LatitudeLongitude.x;
        var y = loc.LatitudeLongitude.y;

        fakeMemorial = false;
        SceneManager.LoadScene("Memoriales");

        //if (x <= -34.616589 && x >= -34.618968 && y <= -58.432249 && y >= -58.434540)
        //{
        //    fakeMemorial = false;
        //    SceneManager.LoadScene("Memoriales");
        //}
        //else
        //{
        //    fakeMemorial = true;
        //    SceneManager.LoadScene("Memoriales");
        //}
    }

    public void MartinMural()
    {
        Martin = true;
        var loc = location.CurrentLocation;
        var x = loc.LatitudeLongitude.x;
        var y = loc.LatitudeLongitude.y;

        if (x >= -34.570529 && x <= -34.570303 && y <= -58.417541 && y >= -58.417628)
        {
            fakeMemorial = false;
            SceneManager.LoadScene("Memoriales");
        }
        else
        {
            fakeMemorial = true;
            SceneManager.LoadScene("Memoriales");
        }

    }


}
