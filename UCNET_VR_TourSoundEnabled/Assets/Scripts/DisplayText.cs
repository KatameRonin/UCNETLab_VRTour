﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DisplayText : MonoBehaviour {

	public bool Display;
	public GameObject txt;
	DateTime check;
	public int c=0;
	// Use this for initialization
	void Start () {

		txt.SetActive (false);
		Display = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Display) {
			if (c == 0) {

				check = DateTime.Now;
				c++;
			}


			DateTime dtn=DateTime.Now;

			TimeSpan dif = dtn.Subtract (check);
			int d = Convert.ToInt32 (dif.TotalSeconds);
			//Debug.Log (d);
			if (d == 2) {
				txt.SetActive (true);

			}
		}
	}

	public void DisplayOn(){

		Display = true;
	}

	public void DisplayOff(){

		Display = false;
		txt.SetActive (false);
		c = 0;

	}
}
