using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour {

  private new Transform transform;
  int rotation_speed = 100;

  void Start(){
    this.transform = GetComponent<Transform>();
  }

  void Update(){  
    
    this.transform.Rotate(new Vector3(Time.deltaTime * rotation_speed, 0, 0), Space.Self);
  }
}
