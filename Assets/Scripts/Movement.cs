using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{

    float speed = 10;
    float rotationSpeed = 100;
    protected NavMeshAgent agent;
    protected virtual void Move(float x,float z)
    {


        transform.Translate(Vector3.forward * z * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * x * rotationSpeed * Time.deltaTime);
    }
    protected virtual void Move(Vector3 m_destination)
    {
        GetComponent<NavMeshAgent>().destination = m_destination;
    }
}
