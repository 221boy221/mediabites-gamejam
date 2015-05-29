using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

    public virtual void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.tag == Tags.PLAYER) {
            OnPlayerTouch(other);
            
        }
        // Override
    }

    public virtual void OnPlayerTouch(Collision2D player) 
    {
        Destroy(gameObject);
        // Override
    }

}
