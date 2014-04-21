using UnityEngine;
using System.Collections;

public class Force : MonoBehaviour
{
	private bool force;
	void Start()
	{
		force = true;
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
			print("I have" + (force?" the":" no") + " force");
	}
	
	public bool ReportForce()
	{
		return force;
	}
}