using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour
{
    public bool cont;
    public void back()
    {
        var x = GameObject.FindGameObjectsWithTag("Memoriales");
        foreach (var memo in x)
        {
            memo.Destroy();
        }
        SceneManager.LoadScene("Mapa");
    }

    public void continueMemo()
    {
        var x = GameObject.Find("fakeMessage(Clone)");
        x.SetActive(false);
    }



}
