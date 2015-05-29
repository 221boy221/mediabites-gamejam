using UnityEngine;
using System.Collections;

public class tree : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other)
    {
        if(other.transform.position.y > transform.position.y)
        {
            other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = GetComponent<SpriteRenderer>().sortingOrder - 1;
        }
        else
        {
            other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = GetComponent<SpriteRenderer>().sortingOrder + 1;
        }
    }
}
