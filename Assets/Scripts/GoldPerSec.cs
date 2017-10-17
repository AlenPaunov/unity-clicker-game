using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPerSec : MonoBehaviour
{

	public UnityEngine.UI.Text goldPerSecondDisplay;
	public Click click;
	public ItemManager[] items;

	void Start ()
	{
		StartCoroutine (AutoTick ());
	}

	void Update ()
	{
		goldPerSecondDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString (GetGoldPerSecond (), true, false);
	}

	public float GetGoldPerSecond ()
	{
		float tick = 0;	
		foreach (ItemManager item in items) {
			tick += item.count * item.tickValue;

		}
		return tick;
	}

	public void AutoGoldPerSecond ()
	{
		click.gold += GetGoldPerSecond () / 10;
	}

	IEnumerator AutoTick ()
	{
		while (true) {
			AutoGoldPerSecond ();
			yield return new WaitForSeconds (0.10f);
		}
	}
}
