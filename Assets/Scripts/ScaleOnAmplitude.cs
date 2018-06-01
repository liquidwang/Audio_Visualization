using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOnAmplitude : MonoBehaviour {

    public float _startScale, _maxScale;
    public bool _useBuffer;
    Material _material;
    public float _red, _green, _blue;

	// Use this for initialization
	void Start ()
    {
        _material = GetComponent<MeshRenderer>().materials[0];
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!_useBuffer)
        {
            transform.localScale = new Vector3((AudioManager._Amplitude * _maxScale) + _startScale, (AudioManager._Amplitude * _maxScale) + _startScale, (AudioManager._Amplitude * _maxScale) + _startScale);
            Color _color = new Color(_red * AudioManager._Amplitude, _green * AudioManager._Amplitude, _blue * AudioManager._Amplitude);
            _material.SetColor("_EmissionColor", _color);
        }
        if(_useBuffer)
        {
            transform.localScale = new Vector3((AudioManager._AmplitudeBuffer * _maxScale) + _startScale, (AudioManager._AmplitudeBuffer * _maxScale) + _startScale, (AudioManager._AmplitudeBuffer * _maxScale) + _startScale);
            Color _color = new Color(_red * AudioManager._AmplitudeBuffer, _green * AudioManager._AmplitudeBuffer, _blue * AudioManager._AmplitudeBuffer);
            _material.SetColor("_EmissionColor", _color);
        }
	}
}
