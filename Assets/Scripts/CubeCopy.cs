using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCopy : MonoBehaviour {

    public GameObject _CubePrefab;
    GameObject[] _Cube = new GameObject[16];

	// Use this for initialization
	void Start ()
    {
		for(int i = 0; i < 16; i++)
        {
            GameObject _instanceSampleCube = (GameObject)Instantiate(_CubePrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "Cube" + i;
            this.transform.eulerAngles = new Vector3(0, 0, -22.5f * i);
            _instanceSampleCube.transform.position = Vector3.forward * 100;
            _Cube[i] = _instanceSampleCube;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
