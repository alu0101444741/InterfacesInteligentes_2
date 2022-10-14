using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModifier : MonoBehaviour {
  private new Renderer renderer;
  public GameObject cylinder;


  void Start(){


    this.renderer = GetComponent<Renderer>();
    this.renderer.material.color = Color.blue;

    this.cylinder = GameObject.FindWithTag("Cylinder_1");
    Debug.Log("Transform X:" + this.cylinder.transform.position.x);
  }

  void Update(){
    
  }
}
