using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private int Health;
    // Start is called before the first frame update
    void Start()
    {
        setHealth(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void setHealth(int hel)
    {
        Health = hel;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {

        }
    }
}
