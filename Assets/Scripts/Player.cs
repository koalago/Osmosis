using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public static Vector3 inputDirection;
	public Organism organism;


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
