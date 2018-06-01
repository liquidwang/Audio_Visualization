using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour {
    public int _band;
    public float _startScale, _maxsScale;
    public bool _useBuffer;
    Material _material;

	// Use this for initialization
	void Start ()
    {
        _material = GetComponent<MeshRenderer> ().materials [0];
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioManager._audioBandBuffer[_band] * _maxsScale) + _startScale, transform.localScale.z);
            Color _color = new Color(AudioManager._audioBandBuffer[_band], AudioManager._audioBandBuffer[_band], AudioManager._audioBandBuffer[_band]);
            _material.SetColor("_EmissionColor", _color);
        }

        if(!_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioManager._audioBand[_band] * _maxsScale) + _startScale, transform.localScale.z);
            Color _color = new Color(AudioManager._audioBand[_band], AudioManager._audioBand[_band], AudioManager._audioBand[_band]);
            _material.SetColor("_EmissionColor", _color);
        }
	}
}
