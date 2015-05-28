using UnityEngine;
using System.Collections;

// Boy Voesten

public class PlayerMovement : MonoBehaviour 
{

    private Rigidbody2D _rbody;
    private Vector2 speed = new Vector2(10, 10);
    private Vector2 movement;

    void Awake() 
    {
        _rbody = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        Inputs();
    }

    void FixedUpdate() 
    {
        Movement();
    }

    void Inputs() 
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY
        );
    }

    void Movement() 
    {
        _rbody.velocity = movement;
        if (_rbody.velocity.x > 0) 
        {
            Flip(1);
        }
        else if (_rbody.velocity.x < 0)
        {
            Flip(-1);
        }
    }

    // Flip object by inverting it's scale X
    private void Flip(int i) 
    {
        Vector3 objScale;
        objScale = transform.localScale;
        objScale.x = i;
        transform.localScale = objScale;
    }

    

}
