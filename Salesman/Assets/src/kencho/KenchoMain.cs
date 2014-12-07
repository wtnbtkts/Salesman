using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KenchoMain : MonoBehaviour {
	public KenchoScreen mScreen;
	public GameObject NextButton;
	public KenchoKen Tokyo;
	public KenchoKen Chiba;
	public KenchoKen Kanagawa;
	public KenchoKen Saitama;
	public KenchoKen Gunma;
	public KenchoKen Tochigi;
	public KenchoKen Ibaraki;
	KenchoKen []mKens;
	enum State {
		WaitAnimation,
		ChoiceKen,
		Answer,
		WaitTap,
	}
	State mState;

	// Use this for initialization
	void Start () {
		if (GameSetting.ShouldInit()) {
			GameSetting.Init();
		}
		mState = State.WaitAnimation;
		NextButton.SetActive(false);
		mKens = new KenchoKen[(int)Ken.Count];
		for (int i = 0; i < (int)Ken.Count; i++) {
			mKens[i] = GetKenObject((Ken)i);
			mKens[i].Kencho.SetActive(false);
		}
		mAnimationKenList = GameSetting.getList();
	}
	int mCount = 0;
	int mAnimationIndex = 0;
	List<Ken> mAnimationKenList;
	
	// Update is called once per frame
	void Update () {
		switch(mState) {
		case State.WaitAnimation:
			if (mAnimationKenList == null || mAnimationKenList.Count <= mAnimationIndex) {
				mState = State.ChoiceKen;
				return;
			}
			mCount++;
			if (mCount > 10) {
				mCount = 0;
				KenchoKen ken = GetKenObject(mAnimationKenList[mAnimationIndex]);
				ken.Kencho.SetActive(true);
				mAnimationIndex++;
			}
			break;
		case State.ChoiceKen:
			Ray ray;
			RaycastHit hit;
			float distance = 1000.0f; //光線を伸ばす距離
			
			if (Input.GetMouseButtonDown(0)) {
				//メインカメラのスクリーン上のポイントを光線に変換
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				
				Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
				
				if (aCollider2d) {
					GameObject obj = aCollider2d.transform.gameObject;
					OnPressKen(obj.name);
				}
			}
	      break;
		case State.Answer:
			if (Input.GetKeyDown(KeyCode.Alpha1)) {
				OnPressAnswer();
			}
			break;
		case State.WaitTap:
			if (Input.GetKeyDown(KeyCode.Alpha1)) {
				ChangeNextScene();
			}
			break;
		}
	}
	public void OnPressAnswer() {
		string answer = mScreen.GetAnswer ();
		if (KenchoAnswer.IsCorrectKenchoshozaichi(GameSetting.GetKen(), answer)) {
			mScreen.SetIsCorrest(true);
		} else {
			mScreen.SetIsCorrest(false);
		}
		mState = State.WaitTap;
		NextButton.SetActive(true);
		mScreen.SetExplanation();
	}
	public void ChangeNextScene() {
		Application.LoadLevel("quiz");
	}
	GameObject GetKencho(Ken ken) {
		return GetKenObject(ken).Kencho;
	}
	KenchoKen GetKenObject(Ken ken) {
		KenchoKen obj = Tokyo;
		switch(ken) {
		case Ken.Tokyo:
			obj = Tokyo;
			break;
		case Ken.Chiba:
			obj = Chiba;
			break;
		case Ken.Ibaraki:
			obj = Ibaraki;
			break;
		case Ken.Saitama:
			obj = Saitama;
			break;
		case Ken.Tochigi:
			obj = Tochigi;
			break;
		case Ken.Gunma:
			obj = Gunma;
			break;
		case Ken.Kanagawa:
			obj = Kanagawa;
			break;
		default:
			break;
		}
		return obj;
	}
    void OnPressKen(string button) {
		if (button == "chiba") {
			OnPressKen(Ken.Chiba);
		} else if (button == "Ibaraki") {
			OnPressKen(Ken.Ibaraki);
		} else if (button == "tokyo") {
			OnPressKen(Ken.Tokyo);
		} else if (button == "kanagawa") {
			OnPressKen(Ken.Kanagawa);
		} else if (button == "saitama") {
			OnPressKen(Ken.Saitama);
		} else if (button == "gunma") {
			OnPressKen(Ken.Gunma);
		} else if (button == "tochigi") {
			OnPressKen(Ken.Tochigi);
		}
	}
	void OnPressKen(Ken ken) {
		if (GetKenObject(ken).Kencho.activeSelf) 
			return;
		GameSetting.SetKen(ken);
		mScreen.ShowAfterPanel();
		mState = State.Answer;
	}
}
