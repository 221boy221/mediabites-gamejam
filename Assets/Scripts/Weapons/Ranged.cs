using UnityEngine;
using System.Collections;

public class Ranged : Weapon {

    private float _fireDelay;
    private float _timeSinceLastShot;
    private GameObject _owner;
    [SerializeField]
    private GameObject _projectile;

    public void SetValues(float fireDelay, GameObject owner) {
        _owner = owner;
        _fireDelay = fireDelay;
    }

    override public void Shoot() {
        if (Time.time > _fireDelay + _timeSinceLastShot) {
            Fire();
        }
    }

    private void Fire() {
        Debug.Log("Ranged - Fire");
        GameObject projectile = (GameObject)GameObject.Instantiate(_projectile, _owner.transform.position, Quaternion.identity);
        _timeSinceLastShot = Time.time;
    }

}
