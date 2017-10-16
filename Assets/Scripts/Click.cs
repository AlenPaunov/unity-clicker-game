﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{

	public UnityEngine.UI.Text goldDisplay;
	public UnityEngine.UI.Text goldPerClickDisplay;
	public float gold = 0.0f;
	public int goldPerClick = 1;

	// Update is called once per frame
	void Update ()
	{
		goldDisplay.text = "Gold: " + gold.ToString("f0");
		goldPerClickDisplay.text = goldPerClick + " gold/click ";
	}
		
	public void Clicked ()
	{
		gold += goldPerClick;
	}
}