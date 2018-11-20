using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour {

    public SceneFader fader;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape"))
        {
            fader.FadeTo("MainMenu");
        }
	}
}
