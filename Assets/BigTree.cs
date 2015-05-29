using UnityEngine;
using System.Collections;

public class BigTree : MonoBehaviour {

    public int helth;
	// Use this for initialization
	void Start () 
    {
        helth = 100;
	}
	void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == Tags.ENEMY)
        {
            helth--;
        }
    }
	
}
