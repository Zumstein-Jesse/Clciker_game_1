using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float killcost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    private float _baseCost;

    private void Start()
    {
        _baseCost = killcost;
    }

    private void Update()
    {
        itemInfo.text = itemName + "\nCost: " + killcost + "\nPower: " + clickPower;
    }

    public void PurchaseUpgrade()
    {
        if (click.kills >= killcost)
        {
            click.kills -= killcost;
            count += 1;
            click.killsperclick += clickPower;
            killcost = Mathf.Round (_baseCost * Mathf.Pow(1.15f, count));
        }
}
}
