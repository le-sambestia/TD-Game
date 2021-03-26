using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard Turret Purchased");
        buildManager.SetTurretToBuild(buildManager.StandardTurretPrefab);
    } 
    public void AnotherStandardTurret()
    {
        Debug.Log("Another Turret Purchased");
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
}
