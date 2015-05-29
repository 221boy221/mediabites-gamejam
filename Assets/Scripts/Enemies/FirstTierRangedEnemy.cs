using UnityEngine;
using System.Collections;

public class FirstTierRangedEnemy : BaseEnemy {

	void Awake()
	{
		base.Awake();

		//Set Health
		health = 5.0f;

		//Set Type Enemy
		isRangedEnemy = true;

		//Set Distances
		minDistanceKept = 6f;
		maxDistanceKept = 5.99f;
	}

	void Update()
	{
		base.Update();
	}

}