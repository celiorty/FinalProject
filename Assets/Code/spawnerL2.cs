using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnerL2 : MonoBehaviour {
	
	public GameObject[] enemies;
	public Vector3 spawnValues; //boundaries and such
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool stop;
	int randEnemy; //random enemy
		
	//score keeping
	public Text scoreText;
	private int score;
	
	
	// Use this for initialization
	void Start ()
	{
		score = 0;
		StartCoroutine (waitSpawn ());
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//randomizes time for spawn
		spawnWait = Random.Range (spawnLeastWait, spawnMostWait);
		SetScoreText();
	}
	
	//waits amount of time before spawning
	IEnumerator waitSpawn()
	{
		yield return new WaitForSeconds (startWait);
		while (!stop)
		{
			randEnemy = Random.Range (0, 2);
			
			//picks random spawn position on xyz plane and instantiates
			//surface of cube is 5,5,5, so need to do at least +.5
			//Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), Random.Range (-spawnValues.y, spawnValues.y),
			//                                     Random.Range (-spawnValues.z, spawnValues.z));

			Vector3 spawnPosition = new Vector3 (1, 1,
			                                     Random.Range (3, spawnValues.z));
			GameObject tempEnemy = Instantiate (enemies [randEnemy], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);
			
			//automatically destroys after some time
			Destroy (tempEnemy, 5.0f);
			
			yield return new WaitForSeconds (spawnWait);
		}
	}
	
	public void AddScore(int newScoreValue)
	{
		score += newScoreValue;
		SetScoreText();
	}
	
	void SetScoreText()
	{
		scoreText.text = "Score: " + score.ToString ();
	}
	
	
}
