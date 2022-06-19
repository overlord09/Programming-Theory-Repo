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
      Move(rotation,direction);

    }
}
