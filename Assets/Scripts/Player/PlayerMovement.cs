using UnityEngine;
using System.Collections;

// Boy Voesten

public class PlayerMovement : MonoBehaviour 
{

    private Rigidbody2D _rbody;
    private Vector2 speed = new Vector2(4, 3);
    private Vector2 movement;
    private Animator _anim;

    void Awake() 
    {
        _rbody = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
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
        bool isMoving;

        _rbody.velocity = movement;
        if (_rbody.velocity.x > 0) 
        {
            Flip(-1);
            isMoving = true;
        }
        else if (_rbody.velocity.x < 0)
        {
            Flip(1);
            isMoving = true;
        } 
        else if (_rbody.velocity.y != 0) 
        {
            isMoving = true;
        }
        else 
        {
            isMoving = false;
        }

        if (isMoving) 
        {
            _anim.Play("charWalk");
        } 
        else 
        {
            _anim.Play("charIdle");
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
