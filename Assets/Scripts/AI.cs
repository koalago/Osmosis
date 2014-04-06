using UnityEngine;
using System.Collections;


public enum Action
{
	idle,
	chase,
	attack,
	flee
}

public class AI : MonoBehaviour
{
	private Organism organism;
	private Action _action;
	public Action action
	{
		set { _action = value; }
		get { return _action; }
	}

	void Start()
	{
		organism = GetComponent<Organism>();
	}


	public bool CanSeeEnemy()
	{
		return false;
	}



	void Update()
	{
		if (action == Action.idle)
		{
			organism.Move(organism.rigidbody2D.velocity.normalized + new Vector2(Random.Range(-1f,1f),
			                                                                     Random.Range(-1f,1f)));

		}
	}


}
