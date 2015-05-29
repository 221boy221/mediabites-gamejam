using UnityEngine;
using System.Collections;

public class BigTree : MonoBehaviour {

    public int health;
	// Use this for initialization
	void Start () 
    {
        health = 100;
	}
	void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == Tags.ENEMY)
        {
            health -= 20;
            Debug.Log(health);
        }
    }
	
}
