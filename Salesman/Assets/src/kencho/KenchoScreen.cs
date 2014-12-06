using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum Ken {
	Tokyo,
	Chiba,
	Kanagawa,
	Ibaraki,
	Saitama,
	Gunma,
	Tochigi,
}

public class KenchoScreen : MonoBehaviour {
	int mQuestionCount = 0;
	public Text mTextQuestion;
	public Text mTextAnswer;
	public GameObject mMaru;
	public GameObject mBatsu;
	bool mIsKenchoEnd = false;
	// Use this for initialization
	void Start () {
		Init ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void PressButton() {
		if (KenchoAnswer.IsCorrectKenchoshozaichi(GameSetting.GetKen(), mTextAnswer.text)) {
			mMaru.SetActive(true);
		} else {
			mBatsu.SetActive(true);
		}
		mIsKenchoEnd = true;
//		Application.LoadLevel("quiz");
  }
	public void SetKen(Ken ken) {
		mTextQuestion.text = QuizQuestion.get(ken, GameSetting.GetCount());
		GameSetting.AddCount();
	}
	void Init() {
		GameSetting.ResetCount();
	}
}
