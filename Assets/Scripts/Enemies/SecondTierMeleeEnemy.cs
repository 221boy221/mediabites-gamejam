using UnityEngine;
using System.Collections;

public class SecondTierMeleeEnemy : BaseEnemy {

	void Awake()
	{
		base.Awake();

		//Set Health
		health = 20.0f;

		//Set Type Enemy
		isMeleeEnemy = true;
	}

	void Update()
	{
		base.Update();
	}

}