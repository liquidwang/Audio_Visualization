using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LettersOnAudio : MonoBehaviour {
	GameObject[] _letterGO = new GameObject[6];
	Material[] _material = new Material[6];
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 6; i++) {
			_letterGO [i] = this.transform.GetChild(i).gameObject;
			_material[i] = new Material(_letterGO [i].transform.GetChild(0).GetComponent<Renderer>().material);
			_letterGO [i].transform.GetChild (0).GetComponent<Renderer> ().material = _material [i];
		}
	}
	
	// Update is called once per frame
	void Update () {
		bool rightDirection = true;
		for (int i = 0; i < 6; i++) {
			if (rightDirection)
			{
				_letterGO [i].transform.localEulerAngles = new Vector3 (0, (AudioManager._AmplitudeBuffer * 90f), 0);
			}
			else
			{
				_letterGO [i].transform.localEulerAngles = new Vector3 (0, -(AudioManager._AmplitudeBuffer * 90f), 0);
			}
			rightDirection = !rightDirection;
			_letterGO [i].transform.localScale = new Vector3 (1, 1 + (AudioManager._audioBandBuffer[i+1] * 3), 1);
			Color EmissionColor = new Color (AudioManager._audioBand[i+1], AudioManager._audioBand[i+1], AudioManager._audioBand[i+1], 1);
			_material [i].SetColor ("_EmissionColor", EmissionColor);

		}
	}
}
