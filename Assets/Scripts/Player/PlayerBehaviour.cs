using UnityEngine;
using UnityEngine.UI;
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
        Debug.Log(_maxHealth);
        _health -= dmg;
        if(_health < 0) {
            death();
        }
        
    }

    void death() {
        Application.LoadLevel("GameOverScene");
    }

    void Update()
    {
        Debug.Log(_maxHealth);
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
