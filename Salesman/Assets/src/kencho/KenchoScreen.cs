using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KenchoScreen : MonoBehaviour {
	int mQuestionCount = 0;
	public GameObject mBeforePanel;
	public GameObject mAfterPanel;
	public GameObject Explanation;
	public Text mTextQuestion;
	public Text mTextAnswer;
	public Text mTextExplanation;
	public GameObject mMaru;
	public GameObject mBatsu;
	bool mIsKenchoEnd = false;
	void Start () {
		Init ();
	}

	void Update () {
	}
	public void SetIsCorrest(bool isCorrect) {
		if (isCorrect) {
			mMaru.SetActive(true);
		} else {
			mBatsu.SetActive(true);
		}
	}
	public string GetAnswer() {
		return mTextAnswer.text;
	}
	public void SetExplanation() {
		Explanation.SetActive(true);
		mTextExplanation.text = KenchoAnswer.GetSyozaichi(GameSetting.GetKen());
	}
	public void ShowAfterPanel() {
		mBeforePanel.SetActive(false);
		mAfterPanel.SetActive(true);
	}
	void Init() {
		GameSetting.ResetCount();
		mBeforePanel.SetActive(true);
		mAfterPanel.SetActive(false);
		mMaru.SetActive(false);
		mBatsu.SetActive(false);
		Explanation.SetActive(false);
	}
}
