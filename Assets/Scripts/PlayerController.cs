using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody2D theRB;
	public float moveSpeed;

	public Animator myAnim;

	// Start is called before the first frame update
	void Start() {
			
	}

	// Update is called once per frame
	void Update() {
		theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

    // sets correct walking animation
		myAnim.SetFloat("moveX", theRB.velocity.x);

		myAnim.SetFloat("moveY", theRB.velocity.y);

    // sets from walking animation to idle animation 
    if (theRB.velocity.x != 0 || theRB.velocity.y != 0) {
      myAnim.SetFloat("moving", 1f);

    } else {
     myAnim.SetFloat("moving", 0f);
    }
    
    if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 ||  Input.GetAxisRaw("Vertical") == -1) {
      myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
      myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
		}


	}
}
