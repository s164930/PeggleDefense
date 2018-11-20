using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour {

    public Color hoverColor;
    public Color startColor;

    [Header("Not critical")]
    public GameObject tower;

    private Renderer rend;

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
        }
    }

    public void setTurretToBuild(GameObject turret)
    {
        tower = turret;
    }


 /* 
    private void OnMouseEnter()
    {
        if (!buildManager.CanBuild)
        {
            return;
        }

        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        if (buildManager.GetTowerToBuild() == null)
        {
            return;
        }

        rend.material.color = startColor;
    }
*/

}
