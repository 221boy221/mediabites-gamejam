using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAttacks : MonoBehaviour {

    // ToDo: Inputs - Weapon switching - shooting/attacking
    private Weapon _activeWeapon;
    private List<Weapon> _weaponList;
    private Melee _melee;
    private Ranged _ranged;

    void Start() {
        //_melee = new Melee(1.0f, gameObject);
        _ranged = GetComponent<Ranged>();
        _ranged.SetValues(0.5f, gameObject);

        _melee = GetComponent<Melee>();
        _melee.SetValues(1.0f, gameObject);

        _weaponList = new List<Weapon> { 
            _melee,
            _ranged
        };

        SetWeapon(_weaponList[0]);
    }

    private void Control() {
        if (Input.GetKey(KeyCode.Mouse0)) {
            _activeWeapon.Shoot();
        }
        if (Input.GetKey(KeyCode.Alpha1)) {
            SetWeapon(_weaponList[0]);
        }
        if (Input.GetKey(KeyCode.Alpha2)) {
            SetWeapon(_weaponList[1]);
        }
    }

    void SetWeapon(Weapon weapon) {
        _activeWeapon = weapon;
    }

    void Update() {
        Control();
    }
}
