using UnityEngine;
using System.Collections;

public class QuizExplanation {
	public static string get() {
		return get (GameSetting.GetKen(), GameSetting.GetCount());
	}
	static string get(Ken ken, int count) {
		return "そうらしい。";
	}
}
