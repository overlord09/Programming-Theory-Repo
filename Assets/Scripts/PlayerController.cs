using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Movement
{
    float rotation;
    float direction;

    // Update is called once per frame
    void Update()
    {
        rotation = Input.GetAxis("Horizontal");
        direction= Input.GetAxis("Vertical");
      Move(rotation,direction);//Inheritance

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            GameManager.instance.SubtractHealth(1);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            GameManager.instance.addScore(5);
        }
    }
}
