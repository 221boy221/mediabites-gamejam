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
        _rbody.velocity = movement;

        if (_rbody.velocity.x > 0) 
        {
            Flip(-1);
            _anim.Play("WalkX");
        }
        else if (_rbody.velocity.x < 0)
        {
            Flip(1);
            _anim.Play("WalkX");
        } 
        else if (_rbody.velocity.y < 0) 
        {
            _anim.Play("WalkFront");
        } 
        else if (_rbody.velocity.y > 0) 
        {
            _anim.Play("WalkBack");
        }
        else  
        {
            if (_anim.GetCurrentAnimatorStateInfo(0).IsName("WalkBack"))
            {
                _anim.Play("IdleBack");
            } 
            else if (_anim.GetCurrentAnimatorStateInfo(0).IsName("WalkX") || _anim.GetCurrentAnimatorStateInfo(0).IsName("WalkFront"))
            {
                _anim.Play("Idle");
            }
            
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
