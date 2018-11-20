using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour {


    [Header("Not critical")]
    public GameObject tower;
    public Sprite sprite;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }


    public bool canPlaceTower()
    {
        return tower == null;
    }

    private void OnMouseUp()
    {
        if (!buildManager.CanBuild)
        {
            return;
        }


        if (canPlaceTower())
        {
            buildManager.BuildTower(this);
            transform.GetComponent<SpriteRenderer>().sprite = null;

        }


    }

    public void setTurretToBuild(GameObject turret)
    {
        tower = turret;
    }
 
    private void OnMouseEnter()
    {
        if (!buildManager.CanBuild)
        {
            return;
        }
        transform.GetComponent<SpriteRenderer>().color = Color.blue;
    }

    private void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;

    }


}
