using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjects : MonoBehaviour {

	public GameObject[] enemies;
    public Vector3 center;
    public Vector3 size;

    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
	int randEnemy;

	public Text scoreText;
	private int score;

    void Start () {
		score = 1;
        StartCoroutine(waitSpawn());
    }
	

	void Update () {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
		//score++;
		SetScoreText();
    }


    IEnumerator waitSpawn(){
        yield return new WaitForSeconds(startWait);
        while (!stop){
			randEnemy = Random.Range (0, 2);
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

			GameObject tempEnemy = Instantiate(enemies[randEnemy], pos, Quaternion.identity);

            Destroy(tempEnemy, 5.0f);
            yield return new WaitForSeconds(spawnWait);
        }
    }


    void OnDrawGizmosSelected(){
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }

	public void AddScore(int newScoreValue)
	{

		score += newScoreValue;
		Debug.Log(score);
		SetScoreText();
	}

	void SetScoreText()
	{
		scoreText.text = "Score: " + score.ToString ();
	}


}
