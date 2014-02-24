using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public float followMargin = 0.3f;
	public Transform target;
	public Rigidbody2D organism;


	void FixedUpdate()
	{
		Vector3 screenPosition = Camera.main.WorldToScreenPoint(target.position);
		Vector2 independentScreenPosition = new Vector2(screenPosition.x / Screen.width, screenPosition.y / Screen.height);
//
		if (independentScreenPosition.x < followMargin ||
		    independentScreenPosition.x > 1f - followMargin ||
		    independentScreenPosition.y < followMargin ||
		    independentScreenPosition.y > 1f - followMargin)
		{

		transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * organism.velocity.magnitude);
		}

	}


}
