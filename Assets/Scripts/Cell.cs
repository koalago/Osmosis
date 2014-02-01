using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour ,IDamagable, IKillable
{

	private float _lifeLeft;
	public float lifeLeft
	{
		get
		{
			return _lifeLeft;
		}
		set
		{
			_lifeLeft = value;
			if (_lifeLeft <= 0) Kill();
		}
	}


	//constructor
	public Cell(float lifeLeft)
	{
		_lifeLeft = lifeLeft;
	}


	public void Damage(float damage)
	{
		lifeLeft -= damage;
	}


	public void Kill()
	{
		Debug.LogError("Kill not yet implemented", this);
	}




}
