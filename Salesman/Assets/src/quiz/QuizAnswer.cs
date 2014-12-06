using UnityEngine;
using System.Collections;

 public class QuizAnswer : MonoBehaviour {
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

	public static bool IsCollect(Ken ken, int count, bool isMaru) {
		return false;
		/*
		switch (ken) {
		case Ken.Chiba:
			return isMaru == true;
		default:
			return false;
		case Ken.Tokyo:
			return isMaru == "新宿","しんじゅく";
		default:
			return false;
		case Ken.Kanagawa:
			return isMaru == "横浜","よこはま";
		default:
			return false;
		case Ken.Ibaraki:
			return isMaru == "水戸","みと";
		default:
			return false;
		case Ken.Saitama:
			return isMaru == "さいたま";
		default:
			return false;
		case Ken.Gunma:
			return isMaru == "前橋","まえばし";
		default:
			return false;
		case Ken.Tochigi:
			return isMaru == "宇都宮","うつのみや";
		default:
			return false;
		}
		
	*/
	}
}

/*
		switch(ken) {
		case Ken.Chiba:
			return IsCollectChiba(count);
		case Ken.Tokyo:
			return getTokyo(count);
		case Ken.Kanagawa:
			return getKanagawa(count);
		case Ken.Ibaraki:
			return getIbaraki(count);
		case Ken.Saitama:
			return getSaitama(count);
		case Ken.Gunma:
			return getGunma(count);
		case Ken.Tochigi:
			return getTochigi(count);
		default:
			return getChiba(count);
		}
		return "私だった 2222";
	}

	public static string  IsCollectChiba(int count ,bool isMaru) {
		switch(count) {
		case 0:
			return(isMaru);
		case 1:
			return(isMaru);
		case 2:
			return(isMaru);
		case 3:
			return "東京湾アクアライン開通は2000年である";
		default:
			return(isMaru);
		}
	}
	*/

