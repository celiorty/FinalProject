using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	public GameObject[] enemies;
	public Vector3 spawnValues; //boundaries and such
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool stop;

	int randEnemy; //random enemy

	// Use this for initialization
	void Start ()
	{
		StartCoroutine (waitSpawn ());
	}
	
	// Update is called once per frame
	void Update ()
	{
		//randomizes time for spawn
		spawnWait = Random.Range (spawnLeastWait, spawnMostWait);
	}

	//waits amount of time before spawning
	IEnumerator waitSpawn()
	{
		yield return new WaitForSeconds (startWait);
		while (!stop)
		{
			randEnemy = Random.Range (0, 2);

			//picks random spawn position on xz plane and instantiates
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), 1, Random.Range (-spawnValues.z, spawnValues.z));
			GameObject tempEnemy = Instantiate (enemies [randEnemy], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);

			//automatically destroys after some time
			Destroy (tempEnemy, 5.0f);

			yield return new WaitForSeconds (spawnWait);
		}
	}
}
