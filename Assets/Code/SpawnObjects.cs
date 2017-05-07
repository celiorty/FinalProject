using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public GameObject mousePrefab;
    public Vector3 center;
    public Vector3 size;

    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    void Start () {
        StartCoroutine(waitSpawn());
    }
	

	void Update () {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }


    IEnumerator waitSpawn(){
        yield return new WaitForSeconds(startWait);
        while (!stop){
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

            GameObject tempEnemy = Instantiate(mousePrefab, pos, Quaternion.identity);


            Destroy(tempEnemy, 5.0f);
            yield return new WaitForSeconds(spawnWait);
        }
    }



    void OnDrawGizmosSelected(){
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);

    }
}
