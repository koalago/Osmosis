﻿using UnityEngine;
using System.Collections;

public class OrganismCreator : MonoBehaviour 
{

	public GameObject cellStructurePrefab;
	public GameObject cellCorePrefab;
	public GameObject cellPropulsorPrefab;
	public GameObject cellEyePrefab;

	public int cellSize = 1;







	public GameObject Generate(Matrix matrix)
	{
		Debug.Log("Generate");
		GameObject cellRoot = new GameObject("organism", new System.Type[]{ typeof(Organism)});

		//collumns
		for (int y=0; y<=matrix.size.y; y++)
		{
			//rows
			for (int x=0; x<=matrix.size.x; x++)
			{
				if ((CellType)matrix.Get(new Vector2(x, y)) != CellType.none)
			    {

					CellType type = (CellType)matrix.Get(new Vector2(x, y));
					Object prefab = new Object();

					if (type == CellType.core) 
					{
						prefab = (GameObject)cellCorePrefab;
					}
					else if (type == CellType.structure)
					{
						prefab = (GameObject)cellStructurePrefab;
					}
					else if (type == CellType.eye)
					{
						prefab = (GameObject)cellEyePrefab;
					}
					else if (type == CellType.propulsor)
					{
						prefab = (GameObject)cellPropulsorPrefab;
					}


					GameObject cell = (GameObject)Instantiate(prefab);
					cell.transform.parent = cellRoot.transform;
					cell.transform.localPosition = new Vector3(x * cellSize, -y * cellSize);
				}
			}
		}

		return cellRoot;
	}



}
