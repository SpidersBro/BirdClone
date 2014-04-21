using UnityEngine;
using System.Collections;

public class FlapScript : MonoBehaviour {

	private int score;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
				rigidbody.AddForce (0, 380, 0);
		}

		if (Input.GetKeyDown ("space") && Time.timeScale == 0) {
				Application.LoadLevel (Application.loadedLevel);
		}

	}

	void OnCollisionEnter(Collision collision){
		Debug.Log ("Your score is = " + score);
		resetScore ();
		Time.timeScale = 0;
	}

	
	public void scoreUp(){	
		score++;
	}
	
	public void resetScore(){
		score = 0;
	}


}
