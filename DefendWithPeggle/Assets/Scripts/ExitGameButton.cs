using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExitGameButton : MonoBehaviour {

    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void ExitGameFunction()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.quit();
#endif
    }
}
