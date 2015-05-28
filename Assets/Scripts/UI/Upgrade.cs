using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {

    private int _health;
    private int _maxhealth;
    private int _damage;
    private int _level;
    private int _Upgrade;

	// Use this for initialization
	void Start () {
        _maxhealth = 125;
        _damage = 2;
        _level = 1;
	}

    void Update()
    {
        Debug.Log(_maxhealth);
        Debug.Log(_level);
    }

    public void HealthUpgrade()
    {
        if (_level != 0)
        {
            _maxhealth += 10;
            _level--;
        }
    }

    public void DamageUpgrade()
    {
        if (_level != 0)
        {
            _damage += 2;
            _level--;
        }
    }
}
