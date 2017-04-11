using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ncTriggerScript : MonoBehaviour {

	private AssetBundle myLoadedAssetBundle;
	public bool isActive = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		print("The Trigger object is hit by" + other);

		if (ncGlobalController.isTriggerActive) {
			SavePlayerTransform (other.gameObject);
			ncGlobalController.isSaved = true;
			ncGlobalController.isTriggerActive = false;
			SceneManager.LoadScene("vr01");
		}
	}

	void OnTriggerStay(Collider other){
		
	}

	void OnTriggerExit(Collider other){
		ncGlobalController.isTriggerActive = true;
	}

	public void SavePlayerTransform(GameObject obj){
		
		PlayerPrefs.SetFloat("x", obj.transform.position.x);
		PlayerPrefs.SetFloat("y", obj.transform.position.y);
		PlayerPrefs.SetFloat("z", obj.transform.position.z);
		PlayerPrefs.SetFloat("xr", obj.transform.rotation.x);
		PlayerPrefs.SetFloat("yr", obj.transform.rotation.y);
		PlayerPrefs.SetFloat("zr", obj.transform.rotation.z);
		PlayerPrefs.SetFloat("wr", obj.transform.rotation.w);
	}

}


