using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{

	public UnityEngine.UI.Text itemInfo;
	public Click click;
	public float cost;
	public int count;
	public int tickValue;
	public string itemName;
	public Color standart;
	public Color affordable;

	private float baseCost;

	void Start ()
	{
		baseCost = cost;
	}

	void Update ()
	{
		itemInfo.text = itemName + "\nCost: " + cost + "\nGold: " + tickValue + "/s";
		if (click.gold>=cost) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standart;
		}
	}

	public void PurchasedItem ()
	{
		if (click.gold >= cost) {
			click.gold -= cost;
			count++;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
		}
	}

}
