using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public Transform target;
    private float oldX = 0.0f, newX;
    public float speed = 5;
    public int HP = 100;
    float timeSincePathUpdate;
    Vector3[] path;
    int targetIndex;
    public PlayerScript playerManager;

    private void Start()
    {
        PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
        timeSincePathUpdate = Time.time;
        playerManager = GameObject.Find("PlayerManager").GetComponent<PlayerScript>();
    }

    public void Update()
    {
        if(transform.position.y >= target.position.y - 1)
        {
            playerManager.TakeDamage(1);
            Destroy(this.gameObject);
        }
        newX = target.position.x;
        if (Time.time - timeSincePathUpdate > 1f)
        {
            timeSincePathUpdate = Time.time;
            if (newX != oldX)
            {
                PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
            }           
        }
        oldX = newX;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("anything");
    }

    public void ApplyDamage(int damage)
    {
        if (0 < HP)
        {
            HP -= damage;
        }

        if (HP <= 0)
        {
            Destroy(this.gameObject);
        }
        
    }

    public void OnPathFound(Vector3[] newPath, bool pathSuccessful)
    {
        if (pathSuccessful)
        {
            path = newPath;
            targetIndex = 0;
            StopCoroutine("FollowPath");
            StartCoroutine("FollowPath");
        }
    }

    IEnumerator FollowPath()
    {
        Vector3 currentWaypoint = path[0];

        while (true)
        {
            if(transform.position == currentWaypoint)
            {
                targetIndex++;
                if(targetIndex >= path.Length)
                {
                    yield break;
                }
                currentWaypoint = path[targetIndex];
            }
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint, speed * Time.deltaTime);
            yield return null;
        }
    }

    public void OnDrawGizmos()
    {
        if (path != null)
        {
            for(int i = targetIndex; i < path.Length; i++)
            {
                Gizmos.color = Color.black;
                Gizmos.DrawCube(path[i], new Vector3(0.25f, 0.25f));

                if (i == targetIndex)
                {
                    Gizmos.DrawLine(transform.position, path[i]);
                }
                else
                {
                    Gizmos.DrawLine(path[i - 1], path[i]);
                }
            }
        }
    }
}
