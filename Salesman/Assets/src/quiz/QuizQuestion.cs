using UnityEngine;
using System.Collections;

public class QuizQuestion : MonoBehaviour {
	public static string get(Ken ken, int count) {
		switch(ken) {
		case Ken.Chiba:
			return getChiba(count);
		case Ken.Tokyo:
			return getTokyo(count);
		default:
			return getChiba(count);
		}
	}
	public static string getChiba(int count) {
		switch(count) {
		case 0:
			return "私だった";
		case 1:
			return "私1";
		case 2:
			return "私2";
		case 3:
			return "私3";
		default:
			return "私だった4";
		}
	}
	public static string getTokyo(int count) {
		switch(count) {
		case 0:
			return "tokyo私だった";
		case 1:
			return "tokyo私1";
		case 2:
			return "tokyo私2";
		case 3:
			return "tokyo私3";
		default:
			return "tokyo私だった4";
		}
	}
}
