using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float speed = 1;
	// Update is called once per frame
	void Update () {
        // jos nuolinäppäin tai w on pohjassa
        if (Input.GetAxis("Vertical") > 0)
        {
            // hahmo liikkuu eteenpäin jollain nopeudella
            transform.position += transform.forward*speed;
        }

	}
}
