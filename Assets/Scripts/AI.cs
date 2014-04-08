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

	public float decisionFrequency = 1f;
	public float lastDecision;
	private Vector2 moveTarget = new Vector2();



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
			if (Time.time > lastDecision + decisionFrequency)
			{
				lastDecision = Time.time;

				moveTarget = new Vector2(moveTarget.x + Random.Range(-0.3f,0.3f),
				                                   moveTarget.y + Random.Range(-0.3f, 0.3f));
			}
		}


		organism.Move(moveTarget);
	}










}
