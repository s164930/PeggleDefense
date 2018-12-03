using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDamage : MonoBehaviour {

    private Collider2D[] hits;
    public float attackRange = 5f;
    public int sendDamage = 10;
    public LayerMask enemyDetect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter");
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("enter ball");
            DoDamage();
        }
    }

    void DoDamage()
    {
        hits = Physics2D.OverlapCircleAll(transform.position, attackRange, enemyDetect);
        Debug.Log("enemies in radius:" + hits.Length);
        for(int i = 0; i < hits.Length; i++)
        {
            hits[i].SendMessage("ApplyDamage", sendDamage);
        }

    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
