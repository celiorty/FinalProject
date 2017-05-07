using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForceL1 : MonoBehaviour {

	//for scoring
	public int scoreValue;
	private spawner playerControl;

	void Start()
	{
		//instantiate player control in order to add score
		GameObject playerControlObject = GameObject.FindWithTag ("playerControl");
		playerControl = playerControlObject.GetComponent <spawner>();
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Hit!!");
		if (other.gameObject.CompareTag ("BlackCube"))
		{
			//other.gameObject.SetActive (false);

			playerControl.AddScore (10);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
		if (other.gameObject.CompareTag ("BlueCube"))
		{
			playerControl.AddScore (20);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}

	}
}
