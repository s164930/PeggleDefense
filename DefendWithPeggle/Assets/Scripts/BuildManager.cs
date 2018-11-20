using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    public GameObject towerPrefab;
    public GameObject secondTowerPrefab;

    private TowerBlueprint towerToBuild;


    // Use this for initialization
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Instance already exsists");
            return;
        }
        instance = this;
    }

    public bool CanBuild { get { return towerToBuild != null; }}

    public void BuildTower(PlaceTower node)
    {
        if(PlayerMoney.Money < towerToBuild.cost)
        {
            Debug.Log("u broke");
            return;
        }

        PlayerMoney.Money -= towerToBuild.cost;
        GameObject tower = (GameObject)Instantiate(towerToBuild.prefab, node.transform.position, Quaternion.identity);
        node.tower = tower;

        Debug.Log("Tower build, money: " + PlayerMoney.Money);
    }

    public void SetTowerToBuild(TowerBlueprint tower)
    {
        towerToBuild = tower;
    }


}
