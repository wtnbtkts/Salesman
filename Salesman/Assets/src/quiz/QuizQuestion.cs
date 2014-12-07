using UnityEngine;
using System.Collections;

public class QuizQuestion : MonoBehaviour {
	public static string get() {
		return get (GameSetting.GetKen(), GameSetting.GetCount());
	}
	static string get(Ken ken, int count) {
		switch(ken) {
		case Ken.Chiba:
			return getChiba(count);
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
	}
	static string getChiba(int count) {
		switch(count) {
		case 0:
			return "千葉県は日本で唯一500m以上の山が無い";
		case 1:
			return "成田国際空港の開港は東京ディズニーランド開園より昔である";
		case 2:
			return "幕張メッセの開設は平成である";
		case 3:
			return "東京湾アクアライン開通は2000年である";
		default:
			return "2011年東日本大震災の影響で県の人口が減少した";
		}
	}
	static string getTokyo(int count) {
		switch(count) {
		case 0:
			return "大島、三宅島、八丈島、小笠原諸島は全て東京都の管轄である";
		case 1:
			return "東京都に村はない";
		case 2:
			return "2020年に東京で初めてオリンピックが開催される予定である";
		case 3:
			return "新宿駅の1日あたりの乗降客数は世界第1位である";
		default:
			return "皇居は東京都内にある";
		}
	}
	static string getKanagawa(int count) {
		switch(count) {
		case 0:
			return "県内に横浜市・川崎市の2つだけ政令指定都市がある";
		case 1:
			return "鎌倉時代に鎌倉に鎌倉幕府が置かれた";
		case 2:
			return "横浜市と静岡県の人口差は10 万人以内である";
		case 3:
			return "1853年に神奈川県の浦賀に黒船が来航した";
		default:
			return "県内に空港が無い";
		}
	}
	static string getIbaraki(int count) {
		switch(count) {
		case 0:
			return "茨城県は”いばらきけん”と読む";
		case 1:
			return "茨城県で最も人口が多い市町村はつくば市である";
		case 2:
			return "2005年につくばエクスプレスが開通した";
		case 3:
			return "茨城県には平仮名の市町村が4つある";
		default:
			return "霞ヶ浦は茨城県だけに属する";
		}
	}
	static string getSaitama(int count) {
		switch(count) {
		case 0:
			return "さいたまスーパーアリーナはさいたま市にある";
		case 1:
			return "2001年に浦和市と大宮市が合併してさいたま市となった";
		case 2:
			return "埼玉スタジアム2002でサッカーワールドカップが行われた";
		case 3:
			return "埼玉県は7都県と隣接している";
		default:
			return "市の数40は日本の都道府県で最多である";
		}
	}
	static string getGunma(int count) {
		switch(count) {
		case 0:
			return "群馬県から福島県へ自動車で直接行くことはできない";
		case 1:
			return "群馬県にある館林市では2007 年に最高気温が40℃を超えた";
		case 2:
			return "2010年に富岡製糸場が世界遺産へ正式登録された";
		case 3:
			return "浅間山は2000年以降噴火していない";
		default:
			return "1988年以降ニューイヤー駅伝は群馬県で開催されている";
		}
	}
	static string getTochigi(int count) {
		switch(count) {
		case 0:
			return "栃木県は内陸県である";
		case 1:
			return "栃木県は福島県と隣接している";
		case 2:
			return "日光東照宮は栃木県にある";
		case 3:
			return "草津温泉は栃木県と群馬県の両方に属している";
		default:
			return "栃木県の人口のおよそ3分の1は宇都宮市の人口と同じである";
		}
	}
}
