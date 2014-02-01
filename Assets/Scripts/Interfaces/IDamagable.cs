using UnityEngine;
using System.Collections;

public interface IDamagable 
{

	float lifeLeft
	{
		get;
		set;
	}
	void Damage(float damage);


}
