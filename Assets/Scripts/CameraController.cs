using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
  public Transform target;

    // Start is called before the first frame update
  private void Awake() {
    target = PlayerController.instance.transform;  
  }

    // Update is called once per frame
    //LateUpdate fired 1 frame after Update() is
  void LateUpdate() {
    transform.position = new Vector3(target.position.x, target.position.y, transform.position.z); 
  }
}
