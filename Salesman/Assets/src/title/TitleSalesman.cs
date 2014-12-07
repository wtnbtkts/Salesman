using UnityEngine;
using System.Collections;

public class TitleSalesman : MonoBehaviour {
	public GameObject Body;
	public GameObject Arm;
	public GameObject Head;
	Vector3 mArmDefault;
	Vector3 mBodyDefault;
	int mTime;
	// Use this for initialization
	void Start () {
		mTime = 0;
		mArmDefault = Arm.transform.position;
		mBodyDefault = Body.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (mTime <= 0) { 
			return;
		}
		int height = mTime - 10;
		height = height  < 0 ? 0 :height;
		Arm.transform.position = new Vector3 (mArmDefault.x, mArmDefault.y + height, mArmDefault.z);
		Body.transform.position = new Vector3 (mBodyDefault.x, mBodyDefault.y + height, mBodyDefault.z);
		int bai = 4;
		if (mTime % 10 == 0) {
//			Arm.transform.Rotate(new Vector3(0, 0, bai));
		} else if (mTime % 10 == 5) {
//			Arm.transform.Rotate(- new Vector3(0, 0, bai));
		}
		mTime--;
	}
	public void OnTap() {
		mTime = 30;
	}
}
