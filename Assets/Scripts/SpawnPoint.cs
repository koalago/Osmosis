using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {


	public OrganismCreator organismCreator;


	void Start()
	{
		Spawn();
	}

	void Spawn ()
	{
		Matrix matrix  = new Matrix(new Vector2(1,3), CellType.none);

		matrix.Insert(CellType.eye, new Vector2(0,0));
		matrix.Insert(CellType.core, new Vector2(0,1));
		matrix.Insert(CellType.propulsor, new Vector2(0,2));

		GameObject organismGO = organismCreator.Generate(matrix);
		organismGO.transform.position = transform.position;

		organismGO.AddComponent<AI>();

	}


}
