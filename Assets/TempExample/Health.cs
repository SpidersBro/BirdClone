using UnityEngine;
using System.Collections;
public class Health : MonoBehaviour
{
	public Force script;
	public int health = 5;
	bool hasForce;

	void Start(){
		script = GetComponent<Force>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			hasForce = script.ReportForce();
			if(hasForce)health = 10;
		}
	}
}