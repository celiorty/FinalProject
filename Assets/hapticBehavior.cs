using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hapticBehavior : MonoBehaviour {
	public Texture TextA;
	public Texture TextB;
	public GameObject smallSphere;
	public enum typeFunction {TypeA, TypeB};
	public typeFunction mytypeFunction= typeFunction.TypeA;
	public falconBehaviour plugin = new falconBehaviour();
	public float dia = 0.1f; 
	public float rad = 1.0f; 
	Vector3 previousServoPos;
	public float[] exponentialValues={5,2};
	public float coeffTypeA = 1.0f;
	Vector3 currentServoPos;
	public Vector3 velocity;
	Vector3 force;
	public float distance=0.0F;
	public float pos;
	float coeff;

	void Start(){
		plugin.StartHapticsSystem();
		StartCoroutine(plugin.InitHapticsSystem());
		GetComponent<Renderer>().material.mainTexture=TextA;
	}

	void OnApplicationQuit(){
		plugin.applicationQuit();
	}

	void Update(){
		//transform.localScale = new Vector3(dia, dia, dia);
	}

	void FixedUpdate(){
		velocity=Vector3.Normalize(transform.position-smallSphere.transform.position);
		currentServoPos= plugin.GetServoPos();	//
		smallSphere.transform.position = currentServoPos*5;
		force = Vector3.Normalize(transform.position-smallSphere.transform.position);
		distance=Vector3.Distance(transform.position,smallSphere.transform.position);
		pos = distance-rad;

		switch (mytypeFunction){
		case typeFunction.TypeA:
			if(pos<0){
				coeff=20;
			}
			else{
				coeff=0;
			}
			break;
		case typeFunction.TypeB:
			coeff=25;
			break;
		}
		
		force=force*coeff;
		
		plugin.SetServo(force);	//
		previousServoPos=currentServoPos;
	}
}
