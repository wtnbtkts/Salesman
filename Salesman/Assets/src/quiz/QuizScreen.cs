using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
	int mQuestionCount = 0;
	public Text mTextQuestion;
	public Text mTextAnswer;
	// Use this for initialization
	void Start () {
		Init ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SetKen(Ken ken) {
		mTextQuestion.text = QuizQuestion.get(ken, mQuestionCount);
		mQuestionCount++;
	}
	void Init() {
		mQuestionCount = 0;
	}
}
