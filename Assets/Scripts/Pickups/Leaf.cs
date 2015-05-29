using UnityEngine;
using System.Collections;

public class Leaf : Pickup 
{

    int resources = 10;

    public override void OnCollisionEnter2D(Collision2D other) 
    {
        base.OnCollisionEnter2D(other);
    }

    public override void OnPlayerTouch(Collision2D player) 
    {
        player.gameObject.GetComponent<PlayerResources>().leaves += resources;
        
        base.OnPlayerTouch(player);

        // custom

        
    }
}
