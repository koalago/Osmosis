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


	public Vector2 GetPush (Vector2 direction)
	{
		propulsion = (direction * power);
		return propulsion;
	}


	public void Deactivate()
	{

		propulsion = Vector2.zero;
	}


}
