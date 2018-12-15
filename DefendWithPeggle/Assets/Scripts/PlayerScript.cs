using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public int playerLife;
    public SceneFader fader;
	

	// Update is called once per frame
	void Update () {
		
        if(GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
        {
            fader.FadeTo("LevelSelect");
        }
	}

    public void TakeDamage(int damage)
    {
        playerLife -= damage;
        if(playerLife <= 0)
        {
            fader.FadeTo("LevelSelect");
        }
    }
}
