using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator[] anims;
    bool startAnim = false;

    private void Awake()
    {
        foreach (var anim in anims)
        {
            anim.enabled = false;        
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void anim()
    {
        startAnim = !startAnim;
        if (startAnim)
        {
            foreach (var anim in anims)
            {
                anim.enabled = true;
                anim.Play("showguido");
                anim.Play("show");
            }

        }
        else
        {
            foreach (var anim in anims)
            {
                anim.enabled = true;
                anim.Play("hide");
                anim.Play("hideguido");
            }


        }
    }
}
