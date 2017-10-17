using System.Collections;
using UnityEngine;

public class CurrencyConverter : MonoBehaviour {

	private static CurrencyConverter instance;
	public static CurrencyConverter Instance {
		get {
			return instance;
		}
	}

	void Awake(){
		CreateInstance ();
	}

	void CreateInstance(){
		if (instance == null) {
			instance = this;
		}
	}

	public string GetCurrencyIntoString(float valueToConvert, bool currencyPerSec, bool currencyPerClick){
		string converted;
		if (valueToConvert>=1000000) {
			converted = (valueToConvert/1000000f).ToString("f3")+"M";
		} 
		else if (valueToConvert >= 1000) 
		{
			converted = (valueToConvert/1000f).ToString("f3")+"K";
		} 
		else 
		{
			converted = valueToConvert.ToString("f0");
		}

		if (currencyPerSec) {
			converted += "\ngold/sec";
		}
		else if(currencyPerClick){
			converted+= "\ngold/click";
		}
		return converted;
	}
}
