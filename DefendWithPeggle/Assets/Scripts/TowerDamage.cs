using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDamage : MonoBehaviour {

    private Collider2D[] hits;
    public float attackRange = 5f;
    public int sendDamage = 10;
    public LayerMask enemyDetect;
    public GameObject explosion;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            DoDamage();
            GameObject explosionClone = Instantiate(explosion, gameObject.transform);
            explosionClone.transform.localPosition = Vector3.zero;
            Destroy(explosionClone, 0.2f);
        }
    }

    void DoDamage()
    {
        hits = Physics2D.OverlapCircleAll(transform.position, attackRange, enemyDetect);
        for(int i = 0; i < hits.Length; i++)
        {
            hits[i].SendMessage("ApplyDamage", sendDamage);
        }

    }


    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawWireSphere(transform.position, attackRange);
    //}

  
}
