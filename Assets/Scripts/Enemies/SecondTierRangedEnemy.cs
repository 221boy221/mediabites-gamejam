using UnityEngine;
using System.Collections;

public class SecondTierRangedEnemy : BaseEnemy {

	void Awake()
	{
		base.Awake();
		
		//Set Health
		health = 15.0f;
		
		//Set Type Enemy
		isRangedEnemy = true;
	}
	
	void Update()
	{
		base.Update();
	}
}
