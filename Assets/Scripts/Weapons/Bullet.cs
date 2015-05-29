using UnityEngine;
using System.Collections;

// Boy Voesten

public class Bullet : MonoBehaviour 
{

    private float destroyTime = 5f;
    private float speed = 5f;
    private float damage = 25f;
    private Rigidbody2D _rbody2D;

    void Start() 
    {
        _rbody2D = GetComponent<Rigidbody2D>();
        Destroy(gameObject, destroyTime);
    }
    
    void Update() 
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.transform.tag == "Enemy") 
        {
            // Deal Damage
            other.GetComponent<BaseEnemy>().TakeDamage(damage);
        }
        else if (other.transform.tag != "Player") 
        {
            Destroy(gameObject);
        }
    }
}