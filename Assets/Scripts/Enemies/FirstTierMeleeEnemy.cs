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

		//Set Distances
		minDistanceKept = 1.5f;
		maxDistanceKept = 1.49f;
	}

	void Update()
	{
		base.Update();
	}

}