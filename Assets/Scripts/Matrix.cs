using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Generic Matrix class for unity
/// </summary>
public class Matrix 
{

	private Vector2 _size;
	public Vector2 size
	{
		get 
		{
			return _size;
		}
	}


	//contructor
	public Matrix (Vector2 matrixSize)
	{
		_size = matrixSize;
	}


	public bool isSquare()
	{
		if (size.x == size.y) return true;
		else return false;
	}



}
