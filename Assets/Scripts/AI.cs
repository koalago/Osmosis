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

	public float decisionFrequency = 2f;
	public float lastDecision;
	private Vector2 moveTarget = new Vector2();
	private Vector2 pushVector = new Vector2();


	void Start()
	{
		organism = GetComponent<Organism>();
		lastDecision = Time.time;
	}


	public bool CanSeeEnemy()
	{
		return false;
	}



	void Update()
	{
		//decide position
		if (lastDecision + decisionFrequency < Time.time)
		{
			moveTarget = transform.localPosition + new Vector3(Random.Range(-5f,5f),
			                                                   Random.Range(-5f,5f),
			                                                   0);
			lastDecision = Time.time;
		}



		if (action == Action.idle)
		{
			pushVector = new Vector2(moveTarget.x - transform.localPosition.x,
			                         moveTarget.y - transform.localPosition.y);
		

		}
		organism.Move(pushVector);

	}










}
