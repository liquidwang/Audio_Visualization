using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendOnAudio : MonoBehaviour {
	GameObject[] _blendboxGO = new GameObject[8];
	SkinnedMeshRenderer[] _skinnedMeshRenderer = new SkinnedMeshRenderer[8];
	public Gradient _colorGradient;
	Color[] _color = new Color[8];
	Material[] _material = new Material[8];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 8; i++) {
			_blendboxGO [i] = this.transform.GetChild(i).gameObject;
			_skinnedMeshRenderer [i] = _blendboxGO [i].GetComponent<SkinnedMeshRenderer> ();
			_material[i] = new Material(_skinnedMeshRenderer[i].material);
				_color[i] = _colorGradient.Evaluate((1f / 8f) * i);
				_material[i].SetColor("_Color", _color[i]);
				_skinnedMeshRenderer[i].material = _material[i];
			_blendboxGO[i].transform.GetChild(0).GetComponent<Renderer>().material = _material[i];
			_blendboxGO[i].transform.GetChild(1).GetComponent<Renderer>().material = _material[i];
		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < 8; i++) {
			float weightToSet = 100 - (AudioManager._AmplitudeBuffer * 100);
				_skinnedMeshRenderer [i].SetBlendShapeWeight (1, weightToSet);
			Color EmissionColor = new Color (_color [i].r * AudioManager._audioBand[i], _color [i].g * AudioManager._audioBand[i], _color [i].b * AudioManager._audioBand[i], 1);
			_material [i].SetColor ("_EmissionColor", EmissionColor);
		}
	}
}
