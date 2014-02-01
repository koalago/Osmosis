using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Cluster is made of cells
/// </summary>
public class Cluster : MonoBehaviour
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
			cells = value;
		}

	}



}
