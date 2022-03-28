using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("destroying");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        //yes
    }
    IEnumerator destroying()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") )
        {
          //when Bullet collide with enemy it compare his name wether it is a pistol bullet or rifle bullet
            if (gameObject.CompareTag("PistoBullet"))
            {
                collision.gameObject.GetComponent<EnemyAi>().GetDamage(20);
             
            }
            if (gameObject.CompareTag("RifleBullet"))
            {
                collision.gameObject.GetComponent<EnemyAi>().GetDamage(40);
           
            }
        
        }
        if ( collision.gameObject.CompareTag("Player"))
        {
            //when Bullet collide with enemy it compare his name wether it is a pistol bullet or rifle bullet
            if (gameObject.CompareTag("PistoBullet"))
            {
                collision.gameObject.GetComponent<PlayerDamage>().GetDamage(20);

            }
            if (gameObject.CompareTag("RifleBullet"))
            {
                collision.gameObject.GetComponent<PlayerDamage>().GetDamage(40);

            }

        }

        Debug.Log("BulletDestroyed");
      Destroy(gameObject);
        
    }
}
