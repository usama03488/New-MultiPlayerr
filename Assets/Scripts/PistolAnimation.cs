using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAnimation : MonoBehaviour
{
    public Animator pistolanime;
    // Start is called before the first frame update
    void Start()
    {
        pistolanime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            pistolanime.SetBool("IsMagzine", true);
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            pistolanime.SetTrigger("IsFired");
        }
    }
}
