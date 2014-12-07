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
	static int mScoreStudyOneCount = 0;
	static int mScoreStudy = 10;
	static int mScoreRoute = 20;
	static List<Ken> mList;
	public static void Init() {
		mList = new List<Ken>();
		mCount = 0;
		mScoreStudy = 0;
		mScoreStudyOneCount = 0;
	}
	public static bool ShouldInit() { return mList == null;}
	public static void SetKen(Ken ken) {
		mKen = ken;
		mList.Add (ken);
		mScoreStudyOneCount = 0;
	}
	public static List<Ken> getList() { return mList;}
	public static void AddCount() {
		mCount++;
	}
	public static void ResetCount(){
		mCount = 0;
	}
	public static void AddScoreStudy(int score) { 
		mScoreStudy += score;
		mScoreStudyOneCount++;
	}
	public static int GetScoreStudyCount() { return mScoreStudyOneCount;}
	public static int GetScoreStudy() { return mScoreStudy;}
	public static int GetScoreRoute() { return mScoreRoute;}
	public static Ken GetKen() { return mKen;}
	public static int GetCount() { return mCount;}
	public static bool IsKenEnd() { return mCount == 4;}
}
