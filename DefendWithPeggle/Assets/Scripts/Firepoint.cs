using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firepoint : MonoBehaviour {
    public float force = 0.0f;
    public GameObject ball;
    public float forceIncrease = 5f;
    public Image process;

    private bool isPressed = false;
	// Update is called once per frame
	void Update () {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        direction = direction.normalized;


        if (Input.GetMouseButtonDown(0) && !isPressed)
        {
            isPressed = true;
        }
        if (Input.GetMouseButtonUp(0)){
            isPressed = false;
            GameObject newBullet = Instantiate(ball, transform.position, transform.rotation);
            Rigidbody2D rigid = newBullet.GetComponent<Rigidbody2D>();
            
            rigid.AddForce(direction * force);
            force = 0;
            process.fillAmount = 0f;
        }

        if (isPressed) {
            process.fillAmount = force / 1000f;
            force += forceIncrease;
            if (force > 1000f)
            {
                force = 1000f;
            }
        }


    }
}
