﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace FMG
	{
	public class LevelUnlocker : MonoBehaviour {
		public Text levelText;
		// Use this for initialization
		void Start () {

			levelText.text  = "Unlock level: " + Application.loadedLevel;
			if(Application.loadedLevel< Constants.getMaxLevel() )
			{
				Destroy(gameObject);
			}
		}

		public void unlock()
		{
			int nextMaxLevel = Constants.getMaxLevel()+1;
			Constants.setMaxLevel(nextMaxLevel);
			Destroy(gameObject);
		}
		

	}
}