using UnityEngine;
using System.Collections;

public class Melee : Weapon {

	private float _fireDelay;
    private float _timeSinceLastShot;
    private GameObject _owner;

    public void SetValues(float fireDelay) {
        _fireDelay = fireDelay;
    }

    override public void Shoot() {
        if (Time.time > _fireDelay + _timeSinceLastShot) {
            Attack();
        }
    }

    private void Attack() {
        Debug.Log("Melee - Attack");
        // ToDo: Melee attack

        _timeSinceLastShot = Time.time;
    }

}
