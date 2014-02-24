using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


[RequireComponent(typeof(Rigidbody2D))]


public class Organism : MonoBehaviour
{

	private List<Cell> _cells = new List<Cell>();
	public List<Cell> cells
	{
		get
		{
			return _cells;
		}
		set
		{
			_cells = value;
		}

	}


	void Start()
	{
		SetCells();
	}


	public void SetCells()
	{
		cells = GetComponentsInChildren<Cell>().ToList();
	}



	public void Move(Vector2 direction)
	{
		Vector2 newPush = Vector2.zero;
		float maxVelocity = 0;

		foreach (Cell cell in cells)
		{
			if (cell.abbility != null && cell.abbility.GetType() == typeof(Propulsor) )
			{
				Propulsor propulsor = (Propulsor)cell.abbility;
				//move
				maxVelocity += propulsor.power;
				newPush += new Vector2(direction.x * propulsor.power, direction.y * propulsor.power);
			}
		}

		rigidbody2D.AddForce(newPush);
		rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, maxVelocity * 0.02f);

		transform.rotation = Quaternion.LookRotation(transform.forward, direction);
	}




}
