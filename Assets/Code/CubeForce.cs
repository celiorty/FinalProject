﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForce : MonoBehaviour {
	
	public float speed;
	
	private Rigidbody rb;
	
	private Vector3 movement;
	
	void Start(){
		rb = GetComponent<Rigidbody>();
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
		if (other.gameObject.CompareTag ("BlackEnemy") || other.gameObject.CompareTag ("BlueEnemy")) {
			other.gameObject.SetActive (false);
		}
	}
}