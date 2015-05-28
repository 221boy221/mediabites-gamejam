using UnityEngine;
using System.Collections;

public class BaseEnemy : MonoBehaviour {

	protected float health;

	protected bool isMeleeEnemy;
	protected bool isRangedEnemy;

	void Awake()
	{

	}

	void Update()
	{
		//Every Enemy walks, so this function will be started when an enemy spawns.
		WanderAround();
	}

	//Random Walking of an Enemy
	void WanderAround()
	{

	}

	//Attack for a Ranged-Type Enemy
	void RangedAttack()
	{

	}

	//Attack for a Melee-Type Enemy
	void MeleeAttack()
	{

	}

	//When the Enemy gets hit by an attack take damage
	void TakeDamage(float damageValue)
	{
		if(health >= 0)
		{
			health -= damageValue;
		}
		else if(health == 0)
		{
			Die();
		}
	}

	void Die()
	{

	}

}