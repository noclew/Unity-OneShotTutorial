using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make sure to include these
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class ncGlobalController : MonoBehaviour {

    //singleton
    public static ncGlobalController Singleton;
	public static bool isSaved = false;
	public static bool isTriggerActive = true;

    //Event and Delegate
	public Transform player;
    

    void Awake()
    {
		print (">>>>>Awaken!");
        if (Singleton == null)
        {
            DontDestroyOnLoad(this.gameObject);
            Singleton = this;
            print("global singleton is created");
        }
        else if(Singleton != this)
        {
            Destroy(gameObject);
        }

		if (isSaved && player) {
			player.transform.position = new Vector3 (PlayerPrefs.GetFloat ("x"), PlayerPrefs.GetFloat ("y"), PlayerPrefs.GetFloat ("z"));
			player.transform.rotation = new Quaternion (PlayerPrefs.GetFloat ("xr"), PlayerPrefs.GetFloat ("yr"), PlayerPrefs.GetFloat ("zr"), PlayerPrefs.GetFloat("wr"));
		}

    }

}
