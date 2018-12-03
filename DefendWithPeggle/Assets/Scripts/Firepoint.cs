using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firepoint : MonoBehaviour {
    public int force = 10;
    public int damage = 10;
    public GameObject ball;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(ball, transform.position, transform.rotation);
            Rigidbody2D rigid = newBullet.GetComponent<Rigidbody2D>();
            rigid.AddForce(direction * force);
        }



    }
}
