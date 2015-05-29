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

		//Set Distances
		minDistanceKept = 2f;
		maxDistanceKept = 1.99f;
	}

	void Update()
	{
		base.Update();
	}

}