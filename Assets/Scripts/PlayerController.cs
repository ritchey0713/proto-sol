using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody2D theRB;
	public float moveSpeed;

	public Animator myAnim;

  // reminder: static type variables not accessible in Unity
  public static PlayerController instance;

  public string areaTransitionName;
 
	// Start is called before the first frame update
	private void Awake() {
      // keep duplicates from being assigned
      if (instance == null) {
        // assigns script to whatever it was originally attached to (in this case the plyer object)
        instance = this;
      } else {
        // remove duplicates from being rendered
        Destroy(gameObject);
      }
  }

    void Start() {
    // gameObject here is the player (gameObject refers to the object this script is attached to)
		DontDestroyOnLoad(gameObject);
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
