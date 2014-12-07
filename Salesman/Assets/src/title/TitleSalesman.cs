using UnityEngine;
using System.Collections;

public class TitleSalesman : MonoBehaviour {
	public GameObject Body;
	public GameObject Arm;
	public GameObject Head;
	int mTime;
	// Use this for initialization
	void Start () {
		mTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Arm.transform.position;
		if (mTime %  5 == 0) {
			Arm.transform.position = new Vector3 (pos.x + 10, pos.y + 10, pos.z + 10);
		} else if (mTime % 10 == 2) {
			Arm.transform.position = new Vector3 (pos.x - 10, pos.y - 10, pos.z -  10);
		}
		Arm.transform.Rotate(new Vector3(0, 0, 1));

		mTime++;
	}
}
