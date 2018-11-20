using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectScript : MonoBehaviour {

    public SceneFader fader;
    public GameObject levelButtonPrefab;
    public GameObject levelButtonContainer;

    private void Start()
    {
        Sprite[] thumbnails = Resources.LoadAll<Sprite>("Levels");
        int i = 1;
        foreach(Sprite thumbnail in thumbnails)
        {
            GameObject container = Instantiate(levelButtonPrefab) as GameObject;
            container.GetComponentInChildren<Text>().text = i.ToString();
            container.transform.SetParent(levelButtonContainer.transform);
            i += 1;
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("escape"))
        {
            fader.FadeTo("MainMenu");
        }
	}
}
