using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nc360Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//make balls
		if (Input.GetKeyDown(KeyCode.Backspace))
		{
			SceneManager.LoadScene("main");
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			SceneManager.LoadScene("main");
		}
	}
}
