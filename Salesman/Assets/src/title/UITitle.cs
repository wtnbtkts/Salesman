﻿using UnityEngine;
using System.Collections;

public class UITitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameSetting.Init();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ChangeNextScene(int buttonId)
	{
		switch(buttonId)
		{
		case 0:
			Application.LoadLevel("kencho");
			break;
		default:
			break;
		}
	}
}
