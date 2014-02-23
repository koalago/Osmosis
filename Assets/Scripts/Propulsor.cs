using UnityEngine;
using System.Collections;

public class Propulsor : Ability
{

	public float power;
	private Vector2 _propulsion;
	public Vector2 propulsion
	{
		set
		{
			_propulsion = value;
		}
		get
		{
			return _propulsion;
		}
	}
	

	//constructor
	public Propulsor (float _power)
	{
		power = _power;
	}


	Vector2 Push (Vector2 direction)
	{
		return (direction * power);
	}




}
