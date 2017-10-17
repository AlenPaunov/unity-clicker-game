using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int count = 0;
	public int clickPower;
	public string itemName;
	public Color standart;
	public Color affordable;

	private float baseCost;
	private Slider slider;

	void Start ()
	{
		baseCost = cost;
		slider = GetComponentInChildren<Slider> ();

	}

	void Update ()
	{
		itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;

//		if (click.gold >= cost) {
//			GetComponent<Image> ().color = affordable;
//		} else {
//			GetComponent<Image> ().color = standart;
//		}
		slider.value = click.gold / cost * 100;
		if (slider.value >= 100) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standart;
		}
	}

	public void PurchasedUpgrade ()
	{
		if (click.gold >= cost) {
			click.gold -= cost;
			count++;
			click.goldPerClick += clickPower;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
		}
	}
}
