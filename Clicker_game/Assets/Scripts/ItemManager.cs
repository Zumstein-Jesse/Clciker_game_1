using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    private float _baseCost;

    private void Start()
    {
        _baseCost = cost;
    }

    private void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nKills: " + tickValue + "/s"; 

    }

    public void PurchasedItem()
    {
        if (click.kills >= cost)
        {
            click.kills -= cost;
            count += 1;
            cost = Mathf.Round (_baseCost * Mathf.Pow(1.15f, count));
        }
    }

}
