using UnityEngine;
using System.Collections;

public class Ranged : Weapon 
{

    private float _fireDelay;
    private float _timeSinceLastShot;
    private GameObject _owner;
    [SerializeField]
    private GameObject _projectile;
    Vector2 mousePos;

    public void SetValues(float fireDelay, GameObject owner) 
    {
        _owner = owner;
        _fireDelay = fireDelay;
    }

    override public void Shoot() 
    {
        if (Time.time > _fireDelay + _timeSinceLastShot) {
            Fire();
        }
    }

    void Update() {
        UpdateWeaponRot();
    }

    void UpdateWeaponRot() 
    {
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position); // Calculating the position of the player using pixels

        mousePos.x = Input.mousePosition.x - objectPos.x;
        mousePos.y = Input.mousePosition.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    private void Fire() 
    {
        Debug.Log("Ranged - Fire");
        
        Bullet projectile = Instantiate(_projectile, transform.position, transform.rotation) as Bullet;

        _timeSinceLastShot = Time.time;
    }

}
