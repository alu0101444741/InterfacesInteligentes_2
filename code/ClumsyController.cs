using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClumsyController : MonoBehaviour {
  public int movement_speed;
  private new Transform transform;
  void Start(){
    this.transform = GetComponent<Transform>();
    this.movement_speed = 5;
  }

  void Update(){
    this.move();
  }

  void move() {
    if (Input.GetKey(KeyCode.W)) this.transform.position += (Vector3.forward * Time.deltaTime) * this.movement_speed;
    if (Input.GetKey(KeyCode.A)) this.transform.position += (Vector3.left * Time.deltaTime) * this.movement_speed;
    if (Input.GetKey(KeyCode.S)) this.transform.position += (Vector3.back * Time.deltaTime) * this.movement_speed;
    if (Input.GetKey(KeyCode.D)) this.transform.position += (Vector3.right * Time.deltaTime) * this.movement_speed;
  }
}
