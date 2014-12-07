using UnityEngine;
using System.Collections;

 public class QuizAnswer : MonoBehaviour {
	public static bool IsCollect(bool isMaru) {
		return IsCollect(GameSetting.GetKen(), GameSetting.GetCount(), isMaru);
	}
	static bool IsCollect(Ken ken, int count, bool isMaru) { 
		switch (ken) {
		case Ken.Chiba:
			return IsCollectChiba(count, isMaru);
		case Ken.Tokyo:
			return IsCollectTokyo(count, isMaru);
		case Ken.Kanagawa:
			return IsCollectKanagawa(count, isMaru);
		case Ken.Ibaraki:
			return IsCollectIbaraki(count, isMaru);
		case Ken.Saitama:
			return IsCollectSaitama(count, isMaru);
		case Ken.Gunma:
			return IsCollectGunma(count, isMaru);
		case Ken.Tochigi:
			return IsCollectTochigi(count, isMaru);
		default:
			return IsCollectChiba(count, isMaru);
		}
	}

	static bool IsCollectChiba(int count, bool isMaru) {
		switch(count) {
		case 0:
		case 1:
		case 2:
		default:
			return isMaru;
		case 3:
			return !isMaru;
		}
	}
	static bool IsCollectTokyo(int count, bool isMaru) {
		switch(count) {
		case 0:
		case 3:
		default:
			return isMaru;
		case 1:
		case 2:
			return !isMaru; 
		}
	}
	static  bool IsCollectKanagawa(int count, bool isMaru) {
		switch(count) {
		case 1:
		case 2:
		case 3:
		default:
			return isMaru;
		case 0:
			return !isMaru;
		}
	}
	static bool IsCollectIbaraki(int count, bool isMaru) {
		switch(count) {
		case 0:
		case 2:
		case 3:
			return isMaru;
		case 1:
		default:
			return !isMaru;
		}
	}
	static bool IsCollectSaitama(int count, bool isMaru) {
		switch(count) {
		case 0:
		case 2:
		case 3:
		default:
			return isMaru;
		case 1:
			return !isMaru;
		}
	}
	static bool IsCollectGunma(int count, bool isMaru) {
		switch(count) {
		case 0:
		case 1:
		default:
			return isMaru;
		case 2:
		case 3:
			return !isMaru;
		}
	}
	static bool IsCollectTochigi(int count, bool isMaru) {
		switch(count) {
		case 0:
		case 1:
		case 2:
			return isMaru;
		case 3:
		default:
			return !isMaru;
		}
	}
}
