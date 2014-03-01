using UnityEngine;
using System.Collections;

public class PropulsorUI : MonoBehaviour 
{
	private ParticleSystem particles;
	private Propulsor propulsor;


	void Start()
	{
		propulsor = GetComponent<Propulsor>();
		particles = GetComponent<ParticleSystem>();
	}


	void Update()
	{

		if (propulsor.propulsion != Vector2.zero)
		{
			particles.Emit(3);
		}
		else
		{

		}
	}

}
