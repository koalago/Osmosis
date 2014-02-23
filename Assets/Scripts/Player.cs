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
//			inputDirection = new Vector2((((Input.mousePosition.x - Screen.width/2) + Camera.main.WorldToScreenPoint(organism.transform.position).x - Screen.width/2)) / Screen.width,
//			                             (((Input.mousePosition.y - Screen.height/2) + Camera.main.WorldToScreenPoint(organism.transform.position).y - Screen.height/2)) / Screen.height );

			Vector3 screenPosition = Camera.main.WorldToScreenPoint(organism.transform.position);
			Vector3 dependantDirection = Input.mousePosition - screenPosition;

			inputDirection = new Vector3(dependantDirection.x * (1f/(float)Screen.width), dependantDirection.y * (1f/(float)Screen.height));


			organism.Move(-inputDirection * Time.deltaTime);

		}
	}

}
