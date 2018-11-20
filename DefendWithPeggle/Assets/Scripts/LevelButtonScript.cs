using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelButtonScript : MonoBehaviour {
    public GameObject fader;
    public void StartLevel()
    {
        string levelIndex = this.GetComponentInChildren<Text>().text;
        fader = GameObject.FindWithTag("FaderTag");
        fader.GetComponent<SceneFader>().FadeTo("Level_" + levelIndex);
    }
}
