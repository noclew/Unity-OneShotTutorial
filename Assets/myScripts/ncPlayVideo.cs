using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ncPlayVideo : MonoBehaviour {

	public MovieTexture movie;
	private AudioSource aud;
	void Awake() {
		aud = GetComponent<AudioSource>();
		aud.clip = movie.audioClip;
	}
		
	void Start () {
		movie.Play();
		aud.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
