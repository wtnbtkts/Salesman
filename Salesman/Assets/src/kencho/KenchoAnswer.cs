using UnityEngine;
using System.Collections;

public class KenchoAnswer : MonoBehaviour {
	public static bool  IsCorrectKenchoshozaichi(Ken ken, string syozaichi) {
		return syozaichi == GetSyozaichi(ken);
	}
	public static string GetSyozaichi(Ken ken) {
		switch (ken) {
		case Ken.Chiba:
			return "ちば";
		case Ken.Tokyo:
			return "しんじゅく";
		case Ken.Kanagawa:
			return "よこはま";
		case Ken.Ibaraki:
			return "みと";
		case Ken.Saitama:
			return "さいたま";
		case Ken.Gunma:
			return "まえばし";
		case Ken.Tochigi:
			return "うつのみや";
		default:
			return "";
		}
	}
}
