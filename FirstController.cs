using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstController : MonoBehaviour {  
  private new Transform transform;
  public int movement_speed;  
  //private new Rigidbody rigidbody;
  //public int force_multiplier;

  void Start(){
    this.transform = GetComponent<Transform>();
    //this.rigidbody = GetComponent<Rigidbody>();

    this.movement_speed = 5;
    //this.force_multiplier = 1;
  }

  void Update(){
    this.move();
    //this.moveWithPhysics();
  }

  void move() {
    if (Input.GetKey(KeyCode.W)) this.transform.position += (Vector3.forward * Time.deltaTime) * this.movement_speed;
    if (Input.GetKey(KeyCode.A)) this.transform.position += (Vector3.left * Time.deltaTime) * this.movement_speed;
    if (Input.GetKey(KeyCode.S)) this.transform.position += (Vector3.back * Time.deltaTime) * this.movement_speed;
    if (Input.GetKey(KeyCode.D)) this.transform.position += (Vector3.right * Time.deltaTime) * this.movement_speed;
  }
/*
  void moveWithPhysics() {
    if (Input.GetKey(KeyCode.W)) this.rigidbody.AddForce(Vector3.forward * this.force_multiplier);
    if (Input.GetKey(KeyCode.A)) this.rigidbody.AddForce(Vector3.left * this.force_multiplier);
    if (Input.GetKey(KeyCode.S)) this.rigidbody.AddForce(Vector3.back * this.force_multiplier);
    if (Input.GetKey(KeyCode.D)) this.rigidbody.AddForce(Vector3.right * this.force_multiplier);
  }
*/
}
