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
		
		if(Input.anyKeyDown){

			print(Input.inputString);

		}

		if (Input.GetKeyDown(KeyCode.Backspace) || Input.GetMouseButtonDown(1))
		{
			SceneManager.LoadScene("main");
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			SceneManager.LoadScene("main");
		}
	}
}
