using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : Movement
{
    [SerializeField] Transform[] areas;
    int destinationPatrol;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!agent.pathPending && agent.remainingDistance<0.2f)
        {
            Move(areas[destinationPatrol].position);//inheritance
        }
    }
    protected override void Move(Vector3 m_destination)//polymorphism
    {
        base.Move(m_destination);
        if (areas.Length > destinationPatrol)
        {
        destinationPatrol=(destinationPatrol+1)%areas.Length;

        }
    }
}
