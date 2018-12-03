using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour {

    public int playerHP = 100;
    public int damage = 5;
    public SceneFader fader;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter collision");
        if (collision.gameObject.tag == "Enemy")
        {
            takeDamage(damage);
            Debug.Log("enter real collision");
        }
    }


    public void takeDamage(int damage)
    {
        Debug.Log(damage);

        if(playerHP > 0)
        {
            playerHP -= damage;
        } else
        {
            fader.FadeTo("Build");
        }
    }

}
