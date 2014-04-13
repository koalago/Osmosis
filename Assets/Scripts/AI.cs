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
	private Vector2 pushVector = new Vector2();


	void Start()
	{
		organism = GetComponent<Organism>();
		moveTarget = new Vector2(1f,1f);
	}


	public bool CanSeeEnemy()
	{
		return false;
	}



	void Update()
	{
		if (action == Action.idle)
		{
			pushVector = new Vector2(moveTarget.x - transform.localPosition.x,
			                         moveTarget.y - transform.localPosition.y);
		

		}
		organism.Move(pushVector.normalized);

	}










}
