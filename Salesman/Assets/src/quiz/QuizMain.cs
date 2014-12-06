using UnityEngine;
using System.Collections;

public class QuizMain : MonoBehaviour {
	public QuizScreen mScreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray;
		RaycastHit hit;
		float distance = 1000.0f; //光線を伸ばす距離

		if (Input.GetMouseButtonDown(0)) {
			mScreen.SetKen(Ken.Chiba);
			//メインカメラのスクリーン上のポイントを光線に変換
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
			
			if (aCollider2d) {
				GameObject obj = aCollider2d.transform.gameObject;
				OnPressButton(obj.name);
			}
		}
	}
	void OnPressButton(string button) {
		if (button == "chiba") {
			OnPressButton(Ken.Chiba);
		} else if (button == "Ibaragi") {
			OnPressButton(Ken.Ibaraki);
		}
	}
	void OnPressButton(Ken ken) {
		mScreen.SetKen(ken);
	}
}
