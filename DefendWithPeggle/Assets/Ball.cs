using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public GameObject Projectile;
    private GameObject cloneProj;
    public float fireSpeed;
    public float fireRate;
    public Transform Player;
    public float speed;
    public Vector3 target;
    public Transform target1;
    // Use this for initialization
    void Start ()
    {
        target = target1.transform.position;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > fireRate)
        {
            fireRate = Time.time + fireSpeed;
            cloneProj = (GameObject)Instantiate(Projectile, transform.position, transform.rotation);
            target = target1.transform.position;


        }

        var delta = speed * Time.deltaTime;
        cloneProj.transform.position = Vector3.MoveTowards(cloneProj.transform.position, target, delta);
        if (cloneProj.transform.position == target)
        {

        }

    }
}
