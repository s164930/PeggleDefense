using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {
    public Transform seeker;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        if(seeker != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(seeker.position.x, transform.position.y, transform.position.z), 10 * Time.deltaTime);
        }
        
	}
}
