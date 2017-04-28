using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {
	public GameObject sphere;

	void OnGUI(){
		if(GUI.Button(new Rect(100,100,100,100),"Enlarge")){
			sphere.GetComponent<hapticBehavior>().radiusOrWidth+=.1F;
		}
		if(GUI.Button(new Rect(300,100,100,100),"Reduce")){
			if(sphere.GetComponent<hapticBehavior>().radiusOrWidth>.1F){
				sphere.GetComponent<hapticBehavior>().radiusOrWidth-=.1F;
			}
		}

	}
}
