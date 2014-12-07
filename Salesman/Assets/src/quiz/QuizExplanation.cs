using UnityEngine;
using System.Collections;

public class QuizExplanation {
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
			return "千葉は基本的に平地なので山がありません。でも心なしかちょっとした坂が多い気がします。";
		case 1:
			return "成田空港は1978年開港し東京ディズニーランドは1983年に開園しました。ちなみにアメリカのディズニーランドは1955年に開園しました。";
		case 2:
			return "幕張メッセは平成元年(1989)に開設しました。ここから数々の音楽の祭典がここで行われるようになったんですね。";
		case 3:
			return "1997年に開通された高速道路のことです。これのおかげで神奈川県から東京湾を横切って千葉に行くことができるようになりました。";
		default:
			return "震災後、東北と関東の太平洋側の都道府県の人口は減ってしまいました。";
		}
	}
	static string getTokyo(int count) {
		switch(count) {
		case 0:
			return "これらの島もなんと東京都なのです。「東京にないじゃん…」と思うところかもしれませんが、東京都に入るのです";
		case 1:
			return "島はあるのに村はないというなんともおかしな話ですが東京には村はありません。";
		case 2:
			return "東京では1964年に一度オリンピックが開かれました。それから2020年は二度目のオリンピックとなります。";
		case 3:
			return "新宿が世界で一番多いということですが、２位は池袋駅、３位は渋谷駅……となんと23位の押上駅まで日本が独占しています。";
		default:
			return "皇居というのは天皇陛下の住居です。東京都の千代田区にあります。";
		}
	}
	static string getKanagawa(int count) {
		switch(count) {
		case 0:
			return "神奈川県では「横浜市」「相模原市」「川崎市」の全3市が政令指定都市となっています。";
		case 1:
			return "昔は「平成」とか「昭和」のことを「～時代」と表しました。そのうちの一つに鎌倉幕府というのがあります。1192年に始まったので1192(いいくに)作ろう鎌倉幕府と覚えましょう。";
		case 2:
			return "静岡県の人口は3,697,651人、横浜市の人口は3,688,773人です。約1万人ほどしか差がありません。";
		case 3:
			return "黒船といわれるアメリカの船が横浜に来たために、これまで外国とかかわっていなかった日本が外国とかかわるようになりました。";
		default:
			return "横浜には空港がないために遠くに旅行するときは羽田空港や成田空港を使います。もちろん船での旅行はできますよ。";
		}
	}
	static string getIbaraki(int count) {
		switch(count) {
		case 0:
			return "いばら「ぎ」って言うと茨城県民はめちゃくちゃ怒るから皆さん気をつけてくださいね。";
		case 1:
			return "茨城で一番人口が多いの「水戸市」です。県庁所在市だけあって人口が多いみたいですね。";
		case 2:
			return "つくばエクスプレスが誕生したおかげで茨城県民は東京や千葉に行きやすくなったんだよ。";
		case 3:
			return "「つくば市」「ひたちなか市」「かすみがうら市」「つくばみらい市」の４つです。つくばはひとつにしてほしいところですね。";
		default:
			return "千葉県にもつながっています。なんと日本で二番目に大きい湖なんですよ。ちなみに、これは私も最近知りました。";
		}
	}
	static string getSaitama(int count) {
		switch(count) {
		case 0:
			return "さいたまスーパーアリーナとはジャニーズやAKBなどの有名アーティストがライブをする有名な会場です。周りにはちょっとしたショッピングモールもあります。";
		case 1:
			return "さいたま市は「浦和市」「大宮市」のほか「与野市」「岩槻市」の4地域が合併してできた市町村です。";
		case 2:
			return "2002年に日本と韓国が共同してワールドカップが行われました。その際にさいたまスタジアム2002が中心に使われました。日本の他の会場も使われました。";
		case 3:
			return "埼玉県は神奈川県を除く関東地方の全都道府県と「山梨県」「長野県」の7都道府県と隣接しています。";
		default:
			return "40も市があるなんて驚きですね。ちなみに二位は愛知県の38で3位は千葉の37です。    ";
		}
	}
	static string getGunma(int count) {
		switch(count) {
		case 0:
			return "近いんですけどね…。高速道路で行く場合も一般道路で行く場合も違う県を経由しないとダメらしいです。";
		case 1:
			return "館林(たてばやし)というのは群馬で一番熱い地域です。千葉も熱いですが館林はそれ以上に熱いので夏は大変ですね。";
		case 2:
			return "教科書にも載っている富岡製糸場の世界遺産登録は2014年の6月21日です。ごく最近なのですね。";
		case 3:
			return "浅間山は2004年2008年2009年に噴火が起きています。噴火や地震などの自然災害は急に起こるので怖いですね。";
		default:
			return "ニューイヤー駅伝とは大学生ではなく大人の人が走る駅伝ですね。群馬県の前橋市の県庁前からスタートします。";
		}
	}
	static string getTochigi(int count) {
		switch(count) {
		case 0:
			return "内陸とは「海に面していない」という意味だね。そのため夏はみんなプールに行くので人があふれちゃいます。一万人プールというプール施設もあります。";
		case 1:
			return "栃木と茨城の真上に福島は位置しています。当然隣接もしています";
		case 2:
			return "日光東照宮の「日光」というのは栃木県の地域名の一つです。「見ざる、言わざる、聞かざる」という面白いサルで有名です。";
		case 3:
			return "草津温泉というのは群馬の名温泉地です。群馬と言えば草津、草津と言えば群馬と言うくらいの名地です。栃木にはかかっていませんね。";
		default:
			return "栃木の総人口は1,980,960人で宇都宮市の人口は517,696人です。宇都宮以外の地域にもちゃんと人は住んでいますよ。";
		}
	}
}
