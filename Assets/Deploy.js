#pragma strict

var DeployPrefab:Transform;

function Start () {
}

function Update () {
    if(Input.GetButtonDown("Fire1") || Input.GetKeyDown("space")){
        var Deploy = Instantiate(DeployPrefab, GameObject.Find("SpawnPoint").transform.position, Quaternion.identity);    
        //Deploy.GetComponent.<Rigidbody>().AddForce(transform.forward*20);

    }
}
