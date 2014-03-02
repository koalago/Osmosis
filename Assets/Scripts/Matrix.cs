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

	/// <summary>
	/// The data. Rows first, colums next.
	/// </summary>
	public List<List<object>> data = new List<List<object>>();
	

	//contructor
	public Matrix (Vector2 matrixSize)
	{
		_size = matrixSize;
		List<object> emptyRow = new List<object>();
		//rows
		for (int i=0; i<matrixSize.x; i++) emptyRow.Insert(i, null);
		//columns
		for (int i=0; i<matrixSize.y; i++) data.Insert(i, emptyRow);
	}
	

	public bool isSquare()
	{
		if (size.x == size.y) return true;
		else return false;
	}


	public int TotalCount()
	{
		return (int)size.x * (int)size.y;
	}
	

	public void Insert(object obj, Vector2 cordinates)
	{
		List<object> row =  data[(int)cordinates.y];
		row.Insert((int)cordinates.x, obj);

	}


	public object Get(Vector2 cordinates)
	{
		List<object> row =  data[(int)cordinates.y];
		return (object)row[(int)cordinates.x];
	}






}
