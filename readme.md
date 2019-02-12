# 概要
ITSS準拠の研修カリキュラム「プログラミングの基礎（B121）」のうち、「文法：繰り返し」の実習としてループ処理を実際に作るサンプルです。
各課題は別々のプログラム（別プロジェクト）として作成してください。また、作成するアプリケーションはWindows Formでもコンソールアプリケーションでもどちらでも構いません。

# 課題

## 事前準備

特に準備はありませんが、Visual StudioでC#のWindows Formプロジェクト、またはコンソールアプリケーションプロジェクトを作成してください。

## 課題1 十個の整数足し算

### 新人用課題文
下記の要件を満たすプログラムを作って、実際に動かしてみてください。

- 10個の整数を画面から入力できるようにする。
- 10個の整数を整数配列に格納する。
- 10個の値が入力されたなら下記のように画面に表示する（10個の値を足し算する式と、答えを下記のように表示する）。

> [例]
>　4 + 3 + 9 + 13 + 1 + 2 + 4 + 0 + 18 + 2 = 56

数値の入力は、テキストボックスを10個、ボタンを1個並べ、ボタンが押されたら10個のテキストボックス内容を配列に格納して計算するようにしてください。

入力された数値を配列に入れることで、ループ処理で足し算しやすくなります。配列の扱いと、配列を使ったループ処理による繰り返し処理の作成練習です。ポイントは、今回は10個の数値ですが、後で20個、30個に変更することになった際になるべく楽に変更できるような作り方にできるかどうか、です。

### 講師用補足
フォームやコンソールからの入力と、配列への数値格納。ForかForEachでのループ処理による加算、表示用文字列の作成を行う課題です。ループの基礎が判っていないとここで詰まるかもしれませんので、どうにも手が動かない場合はある程度一緒に支援しながら作成し、次の課題に進ませる事を優先してください。

ForEachを使ったケースについては無理に教える必要はありませんが、理解度が高いようであれば他の選択肢として紹介してもいいでしょう。最初はForをしっかり使えるようになるほうが大事です。

---

## 課題2 九九の表作成

### 新人用課題文
九九の表を表示するプログラムを作ってください。表といっても、九九の答えがきれいに並んでいればOKです。大まかな手順は下記の通りです。

1. 9 x 9 の二次元整数配列を作る。
1. 上記の配列とループ処理（For、While、Do/Whileなど好きなものどれか）を利用して、2重のループを使って二次元配列に九九の答えを設定する。
1. 上記の二次元配列に入っている数字を、再度2重のループ処理を使って画面に表示する。

#### 補足情報: 二次元整数配列の宣言
課題1では添え字（配列の入れ物につけられた通し番号）が1つだけの配列を使いましたが、九九の表は縦×横が9×9の表になるので、添え字が2つの二次元配列と呼ばれる配列を作ると便利です。二次元配列は縦、横2つの数字で情報の入れ元を特定できる配列で、下記のように宣言して作ることができます。情報の出し入れは「kuku[3,6]」のように、縦、横のマス目の番号を指定します。

```cs
// 行と列の添え字が0～8の二次元整数配列を宣言する
int[,] kuku = new int[9,9];
```

#### 補足情報: 文字列に改行を入れる
文字はそのまま表示するとすべて1行になってしまいます。好きな箇所で改行させるには、C#の場合「\r\n」という特殊な文字を間に挟むと、画面表示される際にそこで改行されます。

```cs
string mojiretsu = "1行目と二行目の間に" + "\r\n" + "改行を入れます。";
```

#### 補足情報: テキストボックスを複数行表示可能にする
九九の結果を表示する際にテキストボックスを用いる場合、テキストボックスで2行以上の表示ができるよう設定する必要があります。この設定はMultiLineプロパティにTrueを設定します。

```cs
TextBox.MultiLine = True;
```

### 講師用補足
この課題では、入力情報無しでいきなり九九の表だけを表示します。二次元配列の取り扱いと、ネストされた二重ループの処理を実際に体験することが目的です。結論だけをみればいきなりベタ文字列で九九の表を出すことも可能ですが、あくまでここはループの練習ということで、二重ループの利用は必須としてください。
この課題についても場合によっては実例を見せて突破させないと困難なケースが考えられます。無理そうな場合はある程度様子を見たのち、ヒントを出しながら一緒に課題をクリアしてください（苦手意識を持たないようにしたい）。

---

## 課題3 九九の表改造：14×14の表にする

### 新人用課題文
課題2のプロジェクトをコピーして新しいプロジェクトを作り、九九の表を1～9の掛け算ではなく、1～14の掛け算（サイズが14×14の乗算表）に改造してください。

### 講師用補足
九九プログラムの拡張です。ここで、配列サイズやループ回数を変えるだけで処理を変えられるということを体験してもらいたいという狙いがあります。後々、変更しやすいプログラムとはどういうものか、という事を考えるきっかけです。

---

## 課題4 カンマ区切り数字の足し算

### 新人用課題文
課題1のプロジェクトをコピーして新しいプロジェクトを作り、下記のように改造してください。

- 入力する数値の数を10個ではなく好きな個数とする。
- 数字はテキストボックス1つから、カンマで区切って入力する。たとえば「2, 5, 7, 1」のように入力したものを、ボタンが押されるとカンマごとに数字を切り出し、配列に格納して計算する。
- 計算処理と結果の表示は課題1と同様とする。

#### 補足情報: カンマ区切りの文字をカンマごとに区切って配列に入れる
この処理は .NET Frameworkにあらかじめ用意されています。下記のように「Split（スプリット）」という命令で、カンマ区切り文字列をカンマごとに配列に入れられます。

```cs
string[] numbers = TextBox.Text.Split(',');
```

### 講師用補足
カンマ区切り文字列から配列データを作る手法や、あらかじめ用意されている便利なメソッドを使ってみる練習です。課題1ではテキストボックスを大量に作っているので、これを1本化、入力にカンマ区切りというルールを設けることで拡張性を持たせる事ができる例として体験しておいてもらう課題です。

---

## 課題5 九九の表作成プログラム改良

### 新人用課題文
課題2または課題3のプロジェクトをコピーして新しいプロジェクトを作成し、下記の要件を満たすように改造してください。

- 1～n の数値を指定すると、指定された数値に対応する九九の表（4であれば4×4、11であれば11×11）を二次元配列で返す関数を作成する。
- 二次元配列を指定すると、それをForm上のテキストボックスなどに表示する関数を作成する。
- Form上でテキストボックスから数値を入力すると、その数値に応じたサイズの九九の表を表示する。

#### 補足情報: 二次元配列のマス目のサイズを取得する
サイズが判らない二次元配列が指定された場合、下記のようにGetLengthメソッドを使うと配列添え字の最大値を取得できます。

```cs
// 配列のサイズを取得する（表示する際には可変サイズの配列から実際のサイズを知る必要があるので）
int[,]=new int[5,4]
totalLength = hairetsu.Length // 20が入ります（5 x 4）
length_1 = hairetsu.GetLength(0)  // 1つ目の次元のサイズ、5が入ります
length_2 = hairetsu.GetLength(1)  // 2つ目の次元のサイズ、4が入ります
```

### 講師用補足
将来の拡張を視野に入れて、処理を分割し関数化する練習です。可能であれば、できあがったプログラムの表層だけデバッグで追い、大まかな処理を追う際にも末端の処理を関数化することで見通しやすくなることを体験させるようなデモを行っても良いかと思います。

---

# サンプルソース概略

こちらは全課題を盛り込んだ正解サンプルです。

## AddNumbers


## CreateKukuList
