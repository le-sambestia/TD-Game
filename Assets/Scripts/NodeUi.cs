using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUi : MonoBehaviour
{
    private Node target;

    public GameObject ui;

    public Text upgradeCost;
    public Button upgradeButton;

    public Text SellAmount;

    public void SetTarget(Node _target)
    {
        target = _target;

        if (!target.isUpgraded)
        {
            upgradeCost.text = target.turretBlueprint.upgradeCost + "Gold";
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeCost.text = "Maxed Out";
            upgradeButton.interactable = false;
        }

        SellAmount.text = target.turretBlueprint.GetSellAmount() + "Gold";

        ui.SetActive(true);
    }

    public void hide()
    {
        ui.SetActive(false);
    }

    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }

    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }
}
