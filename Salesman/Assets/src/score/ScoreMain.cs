using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMain : MonoBehaviour {
	public Text ScoreStudy;
	public Text ScroeRoute;
	public Text ScoreAll;
	void Start () {
		int study = GameSetting.GetScoreStudy();
		int route = GameSetting.GetScoreRoute();
		ScoreStudy.text = study.ToString();
		ScroeRoute.text = route.ToString();
		ScoreAll.text = (study + route).ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
