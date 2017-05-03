#pragma strict

 var cam1 : Camera;
 var cam2 : Camera;
 var cam3 : Camera;
 var cam4 : Camera;
 var cam5 : Camera;
 var cam6 : Camera;
 
 function Start() {
     cam1.enabled = true;
     cam2.enabled = false;
     cam3.enabled = false;
     cam4.enabled = false;
     cam5.enabled = false;
     cam6.enabled = false;
 }
 
 function Update() {
 
     if (Input.GetKeyDown(KeyCode.W)) {
        cam1.enabled = false;
     	cam2.enabled = false;
     	cam3.enabled = false;
     	cam4.enabled = false;
     	cam5.enabled = true;
     	cam6.enabled = false;
     }
     
     if (Input.GetKeyDown(KeyCode.S)) {
        cam1.enabled = false;
     	cam2.enabled = false;
     	cam3.enabled = false;
     	cam4.enabled = false;
     	cam5.enabled = false;
     	cam6.enabled = true;
     }     
     
     if (Input.GetKeyDown(KeyCode.A)) {
        cam1.enabled = false;
     	cam2.enabled = false;
     	cam3.enabled = false;
     	cam4.enabled = true;
     	cam5.enabled = false;
     	cam6.enabled = false;
     }     
     
     if (Input.GetKeyDown(KeyCode.D)) {
        cam1.enabled = false;
     	cam2.enabled = false;
     	cam3.enabled = true;
     	cam4.enabled = false;
     	cam5.enabled = false;
     	cam6.enabled = false;
     }     
     
     if (Input.GetKeyDown(KeyCode.Q)) {
        cam1.enabled = true;
     	cam2.enabled = false;
     	cam3.enabled = false;
     	cam4.enabled = false;
     	cam5.enabled = false;
     	cam6.enabled = false;
     }     
     
     if (Input.GetKeyDown(KeyCode.E)) {
        cam1.enabled = false;
     	cam2.enabled = true;
     	cam3.enabled = false;
     	cam4.enabled = false;
     	cam5.enabled = false;
     	cam6.enabled = false;
     }
     
 }