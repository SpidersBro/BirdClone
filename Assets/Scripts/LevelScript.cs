using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour {

	public FlapScript getScore;
	private Vector3 moveVector = new Vector3(-3,0,0);


	// Use this for initialization
	void Start () {
		gameObject.transform.position =new Vector3(gameObject.transform.position.x,Random.Range(-3f,3f),0f);
		getScore = GameObject.Find("Player").GetComponent<FlapScript>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(moveVector * Time.deltaTime, Space.World);

		if (gameObject.transform.position.x < -10) {
			gameObject.transform.position =new Vector3(6f,Random.Range(-3f,3f),0f);
			getScore.scoreUp();
		}
	}
}
