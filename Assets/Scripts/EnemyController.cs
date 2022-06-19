using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Movement
{
     GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player)
        {
            Move(player.transform.position);//inheritance
        }
    }
}
