using UnityEngine;
using System.Collections;

public class KenchoMain : MonoBehaviour {
	public KenchoScreen mScreen;
	enum State {
		ChoiceKen,
		Answer,
		WaitTap,
	}
	State mState;

	// Use this for initialization
	void Start () {
		mState = State.ChoiceKen;
	}
	
	// Update is called once per frame
	void Update () {
		switch(mState) {
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
					OnPressButton(obj.name);
				}
			}
	      break;
		case State.WaitTap:
			if (Input.GetMouseButton(0)) {
				Application.LoadLevel("quiz");
			}
			break;
		}
	}
	void OnPressButton(string button) {
		if (button == "chiba") {
			OnPressButton(Ken.Chiba);
		} else if (button == "Ibaragi") {
			OnPressButton(Ken.Ibaraki);
		}
		mState = State.WaitTap;
	}
	void OnPressButton(Ken ken) {
		mScreen.SetKen(ken);
		mState = State.Answer;
	}
}
