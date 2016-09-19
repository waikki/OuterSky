using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {
    private Vector3 previousMousePosition;
    private Vector3 changedMousePosition;
    public float sensitivity = 1;

	// Update is called once per frame
	void Update () {

        //Kun hiiren oikeaa nappia pitää pohjassa ja liikuttaa sivulle
        if (Input.GetMouseButton(1) == true)
        {
            //Paljonko hiiren sijainti muuttuu edellisestä framesta
            changedMousePosition = previousMousePosition - Input.mousePosition;
            //Playerparent kääntyy liikkeen mukaisesti
            transform.RotateAround(transform.position, transform.up, changedMousePosition.x*sensitivity);

        }
        previousMousePosition = Input.mousePosition;
	}
}
