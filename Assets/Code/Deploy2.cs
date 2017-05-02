using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deploy2 : MonoBehaviour {

	public GameObject block;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			GameObject tempblock = Instantiate(block, GameObject.Find("SpawnPoint").transform.position, Quaternion.identity);

			Destroy (tempblock, 3.0f);
		}
	}
}
