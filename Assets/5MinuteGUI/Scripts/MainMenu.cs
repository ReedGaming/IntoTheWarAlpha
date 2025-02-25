﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace FMG
{
	public class MainMenu : MonoBehaviour {
		public GameObject mainMenu;
		public GameObject levelSelectMenu;
		public GameObject optionsMenu;
		public GameObject creditsMenu;

		public bool useLevelSelect = true;
		public bool useExitButton = true;

		public GameObject exitButton;


		public void Awake()
		{
			if(useExitButton==false)
			{
				exitButton.SetActive(false);
			}
		}


		public void slideOut(GameObject go,bool slideOut)
		{
			Animator animator = go.GetComponent<Animator>();
			if(animator)
			{
				animator.SetBool("SlideOut",slideOut);
			}

		}
		public void fadeInFadeOut(GameObject go1,GameObject go2)
		{
			go1.SetActive(true);

			go2.SetActive(true);
			slideOut(go1,true);
			slideOut(go2,false);

		}

		public void onCommand(string str)
		{
			if(str.Equals("LevelSelect"))
			{
				Debug.Log ("LevelSelect");
				if(useLevelSelect)
				{
					Constants.fadeInFadeOut(levelSelectMenu,mainMenu);
				}else{
					Application.LoadLevel(1);
				}
			}

			if(str.Equals("LevelSelectBack"))
			{
				Constants.fadeInFadeOut(mainMenu,levelSelectMenu);

			}
			if(str.Equals("Exit"))
			{
				Application.Quit();
			}
			if(str.Equals("Credits"))
			{
				Constants.fadeInFadeOut(creditsMenu,mainMenu);

			}
			if(str.Equals("CreditsBack"))
			{
				Constants.fadeInFadeOut(mainMenu,creditsMenu);


			}

			
			if(str.Equals("OptionsBack"))
			{
				Constants.fadeInFadeOut(mainMenu,optionsMenu);

			}
			if(str.Equals("Options"))
			{
				Constants.fadeInFadeOut(optionsMenu,mainMenu);
			}


		}
	}
}
