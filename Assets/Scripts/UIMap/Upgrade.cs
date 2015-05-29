using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {

    private float _health;
    private float _maxhealth;
    private int _damage;
    private int _points;
    private int _Upgrade;
    AudioSource audio;
    
	void Start () {
        audio = GetComponent<AudioSource>();
        _maxhealth = GameObject.FindGameObjectWithTag(Tags.PLAYER).GetComponent<PlayerBehaviour>().health;
        _damage = 2;
        _points = 1;
	}


    public void HealthUpgrade()
    {
        if (_points != 0)
        {
            _maxhealth += 10;
            _points--;
        }
    }

    public void DamageUpgrade()
    {
        if (_points != 0)
        {
            _damage += 2;
            _points--;
            Debug.Log("hoi");
        }
    }

    public void PlayAudio()
    {
        audio.Play();
    }
}
