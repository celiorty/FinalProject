using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForce : MonoBehaviour {
	
	public float speed;
	
	private Rigidbody rb;
	
	private Vector3 movement;

	public int scoreValue;
	private spawnerL2 playerControl;

	void Start(){
		rb = GetComponent<Rigidbody>();

		//instantiate player control in order to add score
		GameObject playerControlObject = GameObject.FindWithTag ("playerControl2");
		playerControl = playerControlObject.GetComponent <spawnerL2>();
	}
	
	void FixedUpdate(){
		// float moveHorizontal = Input.GetAxis("Horizontal");
		
		Vector3 pos = transform.position;
		
		if (pos.y > 2.5)
		{
			movement = new Vector3(0.0F, -1.0F, 0.0F);
		}
		else if(pos.y <-2.5)
		{
			movement = new Vector3(0.0F, 1.0F, 0.0F);
		}
		else if (pos.x < -2.5)
		{
			movement = new Vector3(1.0F, 0.0F, 0.0F);
		}
		else if (pos.x >2.5)
		{
			movement = new Vector3(-1.0F, 0.0F, 0.0F);
		}
		else if (pos.z < -2.5)
		{
			movement = new Vector3(0.0F, 0.0F, 1.0F);
		}
		else if (pos.z >2.5)
		{
			movement = new Vector3(0.0F, 0.0F, -1.0F);
		}
		else
		{
			movement = new Vector3(0.0F, 0.0F, 0.0F);
		}
		
		
		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
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