using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MoveButton : MonoBehaviour {

    public SceneFader fader;

    public void SceneChange()
    {
        fader.FadeTo("Level_1_Play");
    }


}
