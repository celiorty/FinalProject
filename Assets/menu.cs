using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {
	public GameObject sphere;
	void Start () {
	}

	void Update () {
	}

	void OnGUI(){
		if(GUI.Button(new Rect(200,100,100,50),"Type A")){
			sphere.GetComponent<hapticBehavior>().mytypeFunction=hapticBehavior.typeFunction.TypeA;
			sphere.GetComponent<Renderer>().material.mainTexture=sphere.GetComponent<hapticBehavior>().TextA;
		}
		if(GUI.Button(new Rect(200,200,100,50),"Type B")){
			sphere.GetComponent<hapticBehavior>().mytypeFunction=hapticBehavior.typeFunction.TypeB;
			sphere.GetComponent<Renderer>().material.mainTexture=sphere.GetComponent<hapticBehavior>().TextB;
		}
	}
}
