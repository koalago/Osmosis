using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public static Vector3 inputDirection;
	public OrganismCreator organismCreator;
	public Organism organism;
	public CameraFollow cameraFollow;


	void Start()
	{
		Matrix matrix = new Matrix(new Vector2(3,5), CellType.none);

		matrix.Insert(CellType.eye, new Vector2(1,0));
		matrix.Insert(CellType.core, new Vector2(1,1));
		matrix.Insert(CellType.eye, new Vector2(1,2));
		matrix.Insert(CellType.propulsor, new Vector2(1,3));
		matrix.Insert(CellType.propulsor, new Vector2(2,3));
		matrix.Insert(CellType.propulsor, new Vector2(0,3));
		matrix.Insert(CellType.propulsor, new Vector2(1,4));
		matrix.Insert(CellType.propulsor, new Vector2(2,4));
		matrix.Insert(CellType.propulsor, new Vector2(0,4));

		GameObject organismGO = organismCreator.Generate(matrix);
		organismGO.transform.parent = this.transform;
		cameraFollow.target = organismGO.transform;
		cameraFollow.organism = organismGO.rigidbody2D;
		organism = organismGO.GetComponent<Organism>();
	}




	void Update () 
	{
		if (Input.GetMouseButton(0))
	    {
			Vector3 screenPosition = Camera.main.WorldToScreenPoint(organism.transform.position);
			Vector3 dependantDirection = Input.mousePosition - screenPosition;

			inputDirection = new Vector3(dependantDirection.x * (1f/(float)Screen.width), dependantDirection.y * (1f/(float)Screen.height));

			organism.Move(-inputDirection * Time.deltaTime);
		}
		else if (Input.GetMouseButtonUp(0))
		{
			organism.Deactivate();
		}
	}

}
