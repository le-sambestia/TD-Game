using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint archer;
    public TurretBlueprint ballista;
    public TurretBlueprint crossbowmen;
    public TurretBlueprint mage;
    public TurretBlueprint icemage;
    public TurretBlueprint spearman;
    public TurretBlueprint swordsman;
    public TurretBlueprint wizard;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectArcher()
    {
        Debug.Log("Archer Selected");
        buildManager.SelectTurretToBuild(archer);
    } 
    public void SelectBallista()
    {
        Debug.Log("Missile Launcher Selected");
        buildManager.SelectTurretToBuild(ballista);
    }
    public void SelectCrossbowmen()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretToBuild(crossbowmen);
    }

    public void SelectMage()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretToBuild(mage);
    }

    public void SelectIceMage()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretToBuild(icemage);
    }

    public void SelectSpearman()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretToBuild(spearman);
    }

    public void SelectSwordsman()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretToBuild(swordsman);
    }
    
    public void SelectWizard()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretToBuild(wizard);
    }
}
