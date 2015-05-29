using UnityEngine;
using System.Collections;

// Boy Voesten

public class PlayerBehaviour : MonoBehaviour 
{

    private float _health;
    private float _maxHealth = 100.0f;

	void Start () 
    {
        _health = _maxHealth;
	}

    public void GetDamage(float dmg) 
    {
        _health -= dmg;
        if(_health < 0) {
            death();
        }
        
    }

    void death() {
        // ToDo: GameOver
    }





    // GETTERS & SETTERS

    public float health 
    {
        get 
        {
            return _health;
        } 
        set
        {
            _health = value;
        }
    }
}
