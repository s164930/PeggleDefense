using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameButton : MonoBehaviour {
    public SceneFader fader;
	public void StartGame()
    {
        fader.FadeTo("LevelSelect");
    }
}
