using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBar : MonoBehaviour {
    public GameObject barrel;
    private readonly float distanceToBarrely = 2.5f;
    private readonly float distanceToBarrelx = 0.25f;
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = barrel.transform.TransformPoint(distanceToBarrelx, distanceToBarrely, 0);
        transform.rotation = barrel.transform.rotation;
	}
}
