using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    private float gravity = -9.8f;
    Vector3 velocity;
    public Transform GroundCheck;
    public float grounddistance = 0.4f;
    public LayerMask groundMask;
    bool Isgrounded;
    public float Height = 4f;
    private PhotonView pv; 
    // Start is called before the first frame update
    void Start()
    {
        pv=GetComponent<PhotonView>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
            Isgrounded = Physics.CheckSphere(GroundCheck.position, grounddistance, groundMask);
            if (Isgrounded && velocity.y < 0)
            {
                velocity.y = 0;

            }
        if (pv != null)
        {
            if (pv.IsMine)
            {
                float x = Input.GetAxis("Horizontal");
                float z = Input.GetAxis("Vertical");
                Vector3 move = transform.right * x + transform.forward * z;
                controller.Move(move * speed * Time.deltaTime);
                if (Input.GetKeyDown(KeyCode.Space) && Isgrounded)
                {
                    velocity.y = Mathf.Sqrt(Height * -2f * gravity);
                }
                velocity.y += gravity * Time.deltaTime;
                controller.Move(velocity * Time.deltaTime);
            }
        }
       
           
        }
      
    
}
