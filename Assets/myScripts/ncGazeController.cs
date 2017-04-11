using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]

public class ncGazeController : MonoBehaviour {
	Camera camera;
	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Ray ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) {
			print ("I'm looking at " + hit.transform.name);

			//this is just for demo. The better way is to create a behavior script and add it to each interactive object.
			if (Input.GetMouseButtonDown(0)) {
				print ("Pressed left click on this object.");
				Renderer rend = hit.transform.GetComponent<Renderer> ();
				rend.material.color = Color.green;
			}
		}
	}
}
