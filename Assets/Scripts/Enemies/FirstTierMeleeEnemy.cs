using UnityEngine;
using System.Collections;

public class FirstTierMeleeEnemy : BaseEnemy {

	void Awake()
	{
		base.Awake();

		//Set Health
		health = 10.0f;

		//Set Type Enemy
		isMeleeEnemy = true;
	}

	void Update()
	{
		base.Update();
	}

}