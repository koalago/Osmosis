using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


[RequireComponent(typeof(Rigidbody2D))]


public class Organism : MonoBehaviour
{
	public Matrix matrix;
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
	private Quaternion forwardRotation;
	public float rotationSpeed;

	void Start()
	{
		SetCells();
	}





	public void SetCells()
	{
		cells = GetComponentsInChildren<Cell>().ToList();
	}


	public Organism (Matrix cellTypesMatrix)
	{

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
				newPush += propulsor.GetPush(direction);
			}
		}

		rigidbody2D.AddForce(newPush);
		forwardRotation = Quaternion.LookRotation(transform.forward, direction);
	}



	public void Deactivate()
	{
		foreach (Cell cell in cells)
		{
			if (cell.abbility != null && cell.abbility.GetType() == typeof(Propulsor) )
			{
				Propulsor propulsor = (Propulsor)cell.abbility;
				propulsor.Deactivate();
			}
		}

	}




	void Update()
	{
		float step = (rotationSpeed * Time.deltaTime) / Time.deltaTime;;
		transform.rotation = Quaternion.RotateTowards(transform.rotation, forwardRotation, step);
	}




}
