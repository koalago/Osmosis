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
			inputDirection = new Vector2(((Input.mousePosition.x - Screen.width/2)/ Screen.width), ((Input.mousePosition.y - Screen.height/2) / Screen.height) );
			organism.Move(-inputDirection * Time.deltaTime);
		}
	}
}
