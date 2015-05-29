using UnityEngine;
using System.Collections;

public class BaseEnemy : MonoBehaviour {

	//Animations
	private Animator _anim;

	//Finding the Player
	private GameObject _targetPlayer;
	private GameObject _targetTree;
	private float _distancePlayer;
	private float _distanceTree;

	//Health Bizniz
	protected float health;
	protected bool isAlive = true;

	//Type Enemy Bizniz
	protected bool isMeleeEnemy;
	protected bool isRangedEnemy;

	//Movement Bizniz
	protected float movementSpeed = 4;
	protected float maxDistanceKept;
	protected float minDistanceKept;
	private bool _moving = true;

	public virtual void Awake()
	{
		_anim = GetComponent<Animator>();

		_targetPlayer = GameObject.FindGameObjectWithTag(Tags.PLAYER);
		_targetTree = GameObject.FindGameObjectWithTag(Tags.TREE);
	}

	public virtual void Update()
	{

		if(_targetPlayer)
			_distancePlayer = Vector2.Distance(transform.position, _targetPlayer.transform.position);
		
		if(_targetTree)
			_distanceTree = Vector2.Distance(transform.position, _targetTree.transform.position);

		if(_targetPlayer || _targetTree)
		{
			if(_distancePlayer >= minDistanceKept || _distanceTree >= minDistanceKept)
			{
				_moving = true;
			}
			else if(_distancePlayer <= maxDistanceKept || _distanceTree <= maxDistanceKept)
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
			float t = movementSpeed * Time.deltaTime;

			transform.position = Vector2.MoveTowards(transform.position, _targetTree.transform.position, t);
		}
	}

	//Attack for a Ranged-Type Enemy
	public void RangedAttack()
	{
		//Play Ranged Attack Animation
		_anim.SetTrigger("RangedAttack");

		print("Ranged Attack");
	}

	//Attack for a Melee-Type Enemy
	public void MeleeAttack()
	{
		//Play Melee Attack Animation
		_anim.SetTrigger("MeleeAttack");

		print("Melee Attack");
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
		_anim.SetTrigger("Death");
	}

	void OnBecameInvisible()
	{
		if(!isAlive /* && !_deathAnimation.isPlaying */)
		{
			Destroy(gameObject);
		}
	}

}