using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    public TowerBlueprint standardTower;
    public TowerBlueprint fireTower;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void BuyStandardTurret()
    {
        Debug.Log("Bought turret");
        buildManager.SetTowerToBuild(standardTower);
    }

    public void BuyFireTurret()
    {
        Debug.Log("Bought fire turret");
        buildManager.SetTowerToBuild(fireTower);
    }


}
