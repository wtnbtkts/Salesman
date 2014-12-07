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
	static int []mKenPoint;
	static List<Ken> mList;
	public static void Init() {
		mKenPoint = new int[(int)Ken.Count];
		for (int i = 0; i < (int)Ken.Count; i++) {
			mKenPoint[i] = 0;
		}
		mList = new List<Ken>();
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
	public static Ken GetKen() { return mKen;}
	public static int GetCount() { return mCount;}
	public static bool IsKenEnd() { return mCount == 4;}
}
