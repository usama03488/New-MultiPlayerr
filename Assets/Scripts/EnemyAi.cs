using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    private NavMeshAgent agent;
    private int Health = 100;

    [SerializeField] private Transform playertransform;
    // Start is called before the first frame update
    private void Awake()
    {
        agent= GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            agent.destination = playertransform.position;
        }

    }
    public void GetDamage(int damage)
    {
        Debug.Log("Health is" + Health);
        Health = Health - damage;
    }
}
