using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimations : MonoBehaviour
{
    Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anime.SetTrigger("isLeft");
          
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            //okkk ill work on bullets now
            anime.SetTrigger("isRight");
        }
    }
}
