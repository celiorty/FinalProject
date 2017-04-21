using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {


    public float speed;

    private Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveHeight = Input.GetAxis("Mouse Y");

        Vector3 movement = new Vector3(moveHorizontal, moveHeight, moveVertical);

        rb.AddForce(movement * speed);
    }
}
