using UnityEngine;
using System.Collections;

public class PlayerAnimationController : MonoBehaviour {
	public Animator animator;

	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Vertical") > 0) {    //positiivinen=eteenpäin, negatiivinen=taaksepäin
			animator.SetBool("Walking", true);
		} else {
			animator.SetBool("Walking", false);
		}

        // voi kirjoittaa myös:
        // animator.SetBool("Walking", Input.GetAxis("Vertical") > 0);
	}
}
