using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setG : MonoBehaviour {

    public float xG;
    public float yG;
    public float zG;

    void Start () {
        Physics.gravity = new Vector3(xG, yG, zG);
    }
	

}
