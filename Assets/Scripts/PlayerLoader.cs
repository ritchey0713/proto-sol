using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour {

	// want to grab the Player obj 
	public GameObject player;
    // Start is called before the first frame update
  void Awake() {
		if (PlayerController.instance == null) {
			Instantiate(player);
		}
  }

    // Update is called once per frame
	void Update() {
        
  }
}
