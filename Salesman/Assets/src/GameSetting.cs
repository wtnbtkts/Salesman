using UnityEngine;
using System.Collections;

public class GameSetting {
	static Ken mKen;
	static int mCount;
	public static void SetKen(Ken ken) {
		mKen = ken;
	}
	public static void AddCount() {
		mCount++;
	}
	public static void ResetCount(){
		mCount = 0;
	}
	public static Ken GetKen() { return mKen;}
	public static int GetCount() { return mCount;}
}
