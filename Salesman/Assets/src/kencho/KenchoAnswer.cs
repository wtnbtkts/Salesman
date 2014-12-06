using UnityEngine;
using System.Collections;

public class KenchoAnswer : MonoBehaviour {
	public static bool IsCorrectKenchoshozaichi(Ken ken, string syozaichi) {
		switch (ken) {
		case Ken.Chiba:
			return syozaichi == "ちば";
		case Ken.Tokyo:
			return syozaichi == "しんじゅく";
		case Ken.Kanagawa:
			return syozaichi == "よこはま";
		case Ken.Ibaraki:
			return syozaichi == "みと";
		case Ken.Saitama:
			return syozaichi == "さいたま";
		case Ken.Gunma:
			return syozaichi == "まえばし";
		case Ken.Tochigi:
			return syozaichi == "うつのみや";
		default:
			return false;
		}
	}
}
