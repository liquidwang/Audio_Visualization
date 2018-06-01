using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Time.deltaTime * 30, 0, 0);

        // ...also rotate around the World's Y axis
        transform.Rotate(0, Time.deltaTime * 10, 0, Space.World);

        // Rotate the object around its local z axis at 1 degree per second
        transform.Rotate(0, 0, Time.deltaTime * 20);

    }
}
