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
		Vector2 newTorque = Vector2.zero;

		foreach (Cell cell in cells)
		{
			if (cell.abbility != null && cell.abbility.GetType() == typeof(Propulsor) )
			{
				Propulsor propulsor = (Propulsor)cell.abbility;

				//move

				newPush += new Vector2(direction.x * propulsor.power, direction.y * propulsor.power);
			
				//rotate
				
			}
		}

		rigidbody2D.AddForce(newPush);
	}




}
