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
		minDistanceKept = 1.5f;
		maxDistanceKept = 1.49f;
	}

	void Update()
	{
		base.Update();
	}

}