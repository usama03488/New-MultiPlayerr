using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private int Health = 200;
    public GameObject Ending;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setHealth(int heal)
    {
        Health = heal;
    }
    public  void GetDamage(int damage)
    {
        if (Health > 0)
        {
            Health = Health - damage;
        }
        else
        {
            Debug.Log("You are the winner");
            //Time.timeScale = 0;
            Ending.SetActive(true);
            Destroy(gameObject);
        }
    
    }

}
