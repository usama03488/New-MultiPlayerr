using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private float mouseSensitivity = 100f;
    public Transform playerbody;
    float xRotation = 0f;
    private Transform position;
    // Start is called before the first frame update
    void Start()
    {
       
        //Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float  mousex=Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mousey;
        xRotation = Mathf.Clamp(xRotation, -60f, 60f);

        position.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * mousex);
    }
    public void SetObject(GameObject prefab)
    {
        position= prefab.transform;
    }
}
