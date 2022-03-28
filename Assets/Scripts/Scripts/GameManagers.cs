using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour
{
    public GameObject[] gunslist;
    private GameObject guns;
    private Vector3 gunsposition;
    public Camera cam;
    Vector3 campos = new Vector3(0,2.3f,0);
   
    // Start is called before the first frame update
    void Start()
    {
       gunslist[0].gameObject.SetActive(true);
        cam.transform.parent = gunslist[0].transform;
        cam.transform.localPosition = campos;
        cam.GetComponent<MouseLook>().SetObject(gunslist[0]);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            for(int i = 0; i < gunslist.Length; i++)
            {
                if (i == 1)
                {
                    gunslist[i].gameObject.SetActive(true);
                    cam.transform.parent = gunslist[i].transform;
                    cam.GetComponent<MouseLook>().SetObject(gunslist[i]);
                }
                else
                {
                    gunslist[i].gameObject.SetActive(false);
                }
              
            }

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < gunslist.Length; i++)
            {
                if (i == 2)
                {
                    gunslist[i].gameObject.SetActive(true);
                    cam.transform.parent = gunslist[i].transform;
              
                    cam.GetComponent<MouseLook>().SetObject(gunslist[i]);
                }
                else
                {
                    gunslist[i].gameObject.SetActive(false);
                }
              
            }
        }
        //else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    for (int i = 0; i < gunslist.Length; i++)
        //    {
        //        if (i == 3)
        //        {
        //            gunslist[i].gameObject.SetActive(true);
        //            cam.transform.parent = gunslist[i].transform;
        //            cam.GetComponent<MouseLook>().SetObject(gunslist[i]);
        //        }
        //        else
        //        {
        //            gunslist[i].gameObject.SetActive(false);
        //        }
               
        //    }
        //}
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            for (int i = 0; i < gunslist.Length; i++)
            {
                if (i == 0)
                {
                    gunslist[i].gameObject.SetActive(true);
                    cam.transform.parent = gunslist[i].transform;
                    cam.GetComponent<MouseLook>().SetObject(gunslist[i]);
                }
                else
                {
                    gunslist[i].gameObject.SetActive(false);
                }
             
            }
        }
        
    }
}
