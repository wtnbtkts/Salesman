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
			
			//光線がhitしているオブジェクトがあるかチェック
			//もし該当のオブジェクトがあればhitに格納される
			if (Physics.Raycast(ray, out hit, distance))
			{
				Debug.Log ("hit.collider.gameObject is " + hit.collider.gameObject.name);
				//該当オブジェクトの判別にtagを利用。ここはやりたいことに応じて適宜変更する。
				if (hit.collider.gameObject.tag == "Touchable")
				{
				}
			}
		}
	}
}
