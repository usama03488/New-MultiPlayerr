using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Firing : MonoBehaviour
{
    public GameObject bullet;
    private int Magzine=7;
    private PhotonView pv;
    private int Rounds = 4;
    private int TotalBullets;
    // Start is called before the first frame update
    void Start()
    {
        pv=GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pv != null)
        {
            if (pv.IsMine)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    if (Magzine > 0)
                    {
                        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
                        Magzine--;
                        TotalBullets--;
                    }
                    else
                    {
                        Debug.Log("Press R to reload");
                        Debug.Log("Guns is empty");
                    }
                }
                if (Input.GetKeyDown(KeyCode.R))
                {
                    if (Rounds > 0 || TotalBullets > 0)
                    {
                        if (Magzine == 0)
                        {
                            Rounds--;
                            SetBullets(7);
                        }
                        else if (Magzine > 0)
                        {
                            int diff = 7 - Magzine;
                            if (diff == 0)
                            {
                                //Nothing happens
                            }
                            else if (diff != 0)
                            {
                                AddBullets(diff);
                            }
                        }
                    }


                }
            }
        }
    
  
    }

    void SetBullets(int b)
    {
        Magzine = b;
    }
    void GetBullets()
    {

    }
    void SetTotalBullets()
    {
        TotalBullets = Magzine * Rounds;
    }
    void AddBullets(int remaining)
    {
        Magzine = Magzine + remaining;
    }
}
