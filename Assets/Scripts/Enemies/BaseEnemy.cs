using UnityEngine;
using System.Collections;

public class BaseEnemy : MonoBehaviour {

	//Animator & Rigidbody
	private Animator 	_anim;
	private Rigidbody2D _rigidbody;

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
	private Vector2 position;
	protected float movementSpeed = 4;
	protected float maxDistanceKept;
	protected float minDistanceKept;
	private bool _moving = true;
	private bool _facingLeft = true;

	public virtual void Awake()
	{
		_anim = GetComponent<Animator>();
		_rigidbody = GetComponent<Rigidbody2D>();

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

			_rigidbody.isKinematic = true;
		}
	}

	//Random Walking of an Enemy
	public void Wander()
	{
		if(isAlive)
		{
			float t = movementSpeed * Time.deltaTime;

			if(_moving)
			{
				position = transform.position;
				position = Vector2.MoveTowards(position, _targetTree.transform.position, t);
				_rigidbody.velocity = position;
				_rigidbody.isKinematic = false;
			}

			if( _rigidbody.velocity.x > 0 )
			{
				_anim.SetTrigger("Walk_Side");
				if(_facingLeft)
				{
					Flip ();
				}
			}
			else if( _rigidbody.velocity.x < 0 )
			{
				_anim.SetTrigger("Walk_Side");
				if(!_facingLeft)
				{
					Flip ();
				}
			}

			if( _rigidbody.velocity.y > 0 )
			{
				_anim.SetTrigger("Walk_Front");
			}
			else if( _rigidbody.velocity.y < 0 )
			{
				_anim.SetTrigger("Walk_Back");
			}
		}
	}

	private void Flip()
	{
		_facingLeft = !_facingLeft;

		Vector3 Scale = transform.localScale;
		Scale.x *= -1;
		transform.localScale = Scale;
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
		_anim.SetTrigger("MeleeAttack_Side");

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