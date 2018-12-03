using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Clean" || collision.gameObject.tag =="Enemy")
        {
            Debug.Log("hit");
            Destroy(this.gameObject);
        }
    }

}
