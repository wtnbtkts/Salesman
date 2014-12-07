using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Ken {
	Tokyo,
	Chiba,
	Kanagawa,
	Ibaraki,
	Saitama,
	Gunma,
	Tochigi,
	Count,
}

public class GameSetting {
	static Ken mKen = Ken.Chiba;
	static int mCount = 0;
	static int mScore = 0;
	static List<Ken> mList;
	public static void Init() {
		mList = new List<Ken>();
		mCount = 0;
		mScore = 0;
	}
	public static bool ShouldInit() { return mList == null;}
	public static void SetKen(Ken ken) {
		mKen = ken;
		mList.Add (ken);
	}
	public static List<Ken> getList() { return mList;}
	public static void AddCount() {
		mCount++;
	}
	public static void ResetCount(){
		mCount = 0;
	}
	public static void AddScore(int score) { mScore += score;}
	public static int GetScore() { return mScore;}
	public static Ken GetKen() { return mKen;}
	public static int GetCount() { return mCount;}
	public static bool IsKenEnd() { return mCount == 4;}
}
