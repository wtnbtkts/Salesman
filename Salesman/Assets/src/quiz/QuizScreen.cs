using UnityEngine;
using System.Collections;

public enum Ken {
	Tokyo,
	Chiba,
	Kanagawa,
	Ibaragi,
	Saitama,
	Gunma,
	Tochigi,
}

public class QuizScreen : MonoBehaviour {
	public GameObject mText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SetKen(Ken ken) {
//		Debug.Log ("mText.gameObject.GetComponent<GUIText>().text is " + mText.gameObject.GetComponent<GUIText>().text);
	}
}
