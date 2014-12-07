using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuizMain : MonoBehaviour {
	public Text mQuestion;
	public GameObject AnswerMaru;
	public GameObject AnswerBatsu;
	public GameObject Explanation;
	public Text ExplanationText;
	public GameObject MaruBatsu;
	public GameObject btnMaru;
	public GameObject btnBatsu;
	public GameObject btnNext;
	enum QuizMainState {
		LookQuestion,
		LookResult,
	}
	QuizMainState mState = QuizMainState.LookQuestion;
	void Start () {
		Init();
	}
	
	// Update is called once per frame
	void Update () {
		switch(mState) {
		case QuizMainState.LookQuestion:
			if (Input.GetKeyDown(KeyCode.Alpha1)) {
				OnPressAnswer(true);
			} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
				OnPressAnswer(false);
			}
			break;
		case QuizMainState.LookResult:
			if (Input.GetKeyDown(KeyCode.Alpha1)) {
				ChangeNext();
			}
			break;
		}
	}
	public void OnPressAnswer(bool IsMaru) {
		bool isCollect = QuizAnswer.IsCollect(IsMaru);
		if (isCollect) {
			AnswerMaru.SetActive(true);
			MaruBatsu.transform.position = btnMaru.transform.position;
		} else {
			AnswerBatsu.SetActive(true);
			MaruBatsu.transform.position = btnBatsu.transform.position + new Vector3(0, 50, 0);
		}
		Explanation.gameObject.SetActive(true);
		ExplanationText.text = QuizExplanation.get();
		btnNext.SetActive(true);
		mState = QuizMainState.LookResult;
	}
	public void ChangeNext() {
		if (GameSetting.IsKenEnd()) {
			Application.LoadLevel("kencho");
		} else {
			GameSetting.AddCount();
			Init();
		}
	}
	void Init() {
		mQuestion.text = QuizQuestion.get ();
		AnswerMaru.SetActive(false);
		AnswerBatsu.SetActive(false);
		Explanation.gameObject.SetActive(false);
		mState = QuizMainState.LookQuestion;
		btnNext.SetActive(false);
	}
}
