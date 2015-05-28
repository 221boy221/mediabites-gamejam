using UnityEngine;
using System.Collections;

public class BaseEnemy : MonoBehaviour {

	//Finding the Player
	private GameObject _target;
	private float _distance;

	//Health Bizniz
	protected float health;
	protected bool isAlive = true;

	//Type Enemy Bizniz
	protected bool isMeleeEnemy;
	protected bool isRangedEnemy;

	//Movement Bizniz
	protected float movementSpeed = 2;
	private bool _moving = true;

	private Vector3 _waypoint = new Vector3();
	private float _circleOffset = 5;
	private float _circleRadius = 2;
	private float _maxRange	= 2.5f;

	public virtual void Awake()
	{
		_target = GameObject.FindGameObjectWithTag(Tags.PLAYERTAG);

		if(_target)
			_distance = Vector2.Distance(transform.position, _target.transform.position);
	}

	public virtual void Update()
	{
		if(_target)
		{
			if(_distance >= 2)
			{
				_moving = true;
			}
			else if(_distance <= 1.99f)
			{
				_moving = false;
			}
		}
		else
		{
			_moving = true;
		}

		//Every Enemy walks, so this function will be started automatically when an enemy spawns.
		if(_moving)
		{
			Wander();
		}
		else if(!_moving)
		{
			if(isMeleeEnemy && !isRangedEnemy)
			{
				MeleeAttack();
			}
			else if(!isMeleeEnemy && isRangedEnemy)
			{
				RangedAttack();
			}
		}
	}

	//Random Walking of an Enemy
	public void Wander()
	{
		if(isAlive)
		{
			transform.position += transform.TransformDirection(_waypoint) * movementSpeed * Time.deltaTime;
			if( (transform.position - _waypoint).magnitude < 3 )
			{
				GetNewWaypoint();
			}



//			Vector3 targetPosition = _waypoint - transform.right * _circleOffset;
//			targetPosition = new Vector3(targetPosition.x + Random.Range(-_maxRange, _maxRange), targetPosition.y + Random.Range(-_maxRange, _maxRange), 0);
//			targetPosition.Normalize();
//			targetPosition = targetPosition * _circleRadius;
//			_waypoint = targetPosition + transform.right * _circleOffset;

			//transform.position = Random.insideUnitCircle * 0.2f;
		}
	}

	void GetNewWaypoint()
	{
		float RandomXValue = Random.Range( transform.position.x - _maxRange, transform.position.x + _maxRange );
		float RandomYValue = Random.Range( transform.position.y - _maxRange, transform.position.y + _maxRange );

		_waypoint = new Vector3( RandomXValue, RandomYValue, 0 );
	}

	//Attack for a Ranged-Type Enemy
	public void RangedAttack()
	{
		//Play Ranged Attack Animation
	}

	//Attack for a Melee-Type Enemy
	public void MeleeAttack()
	{
		//Play Melee Attack Animation
	}

	//When the Enemy gets hit by an attack take damage
	public void TakeDamage(float damageValue)
	{
		if(health >= 0)
		{
			health -= damageValue;
		}
		else if(health <= 0)
		{
			health = 0;
			Die();
		}
	}

	void Die()
	{
		isAlive = false;
		//Play Death Animation
	}

	void OnBecameInvisible()
	{
		if(!isAlive /* && !_deathAnimation.isPlaying */)
		{
			Destroy(gameObject);
		}
	}

}