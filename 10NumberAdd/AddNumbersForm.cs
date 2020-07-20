using System;
using System.Windows.Forms;

namespace _10NumberAdd
{
    public partial class AddNumbersForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddNumbersForm"/> class.
        /// </summary>
        public AddNumbersForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 足し算ボタン押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // 異常値を入れた場合もエラーにならないようにしていますが、
            // 文字などが入ると末尾の＋を入れない処理がうまく動きませんので、可能であれば工夫してみてください

            // ForeachとJoinを使ったバージョン
            // TextResult.Text = GetAddResult_byJoinAndForEach(TextSource.Text);

            // Forループを使ったバージョン
            TextResult.Text = GetAddResult_byForLoop(TextSource.Text);
        }

        /// <summary>
        /// 指定された文字列をカンマ区切りの数値とみなして、足し算した式と結果の文字列を返す。
        /// （foreachとJoinで楽しているパターン）
        /// </summary>
        /// <param name="source">処理対象文字列。</param>
        /// <returns>処理結果文字列。</returns>
        private string GetAddResult_byJoinAndForEach(string source)
        {
            int sum = 0;
            string result = string.Empty;

            // 指定された文字列の長さが1以上の場合だけ処理。長さゼロの場合は空文字を返す。
            if (source.Length > 0)
            {
                // テキストボックスに文字が入っている場合
                int eachValue = 0;
                // Stringが持つSplitメソッドでカンマごとに配列に格納
                string[] target = source.Split(',');
                // 配列の各要素について足し算、結果をsumに。数値以外はスキップする。
                foreach (string eachString in target)
                {
                    if (int.TryParse(eachString, out eachValue))
                    {
                        sum += eachValue;
                    }
                }
                // 配列を、String.Joinメソッドで「＋」記号でつないだ文字列に加工。結果もイコールにつなげて文字列を生成。
                result = string.Join(" + ", target) + " = " + sum.ToString();
            }
            return result;
        }

        /// <summary>
        /// 指定された文字列をカンマ区切りの数値とみなして、足し算した式と結果の文字列を返す。
        /// （Forで作るパターン）
        /// </summary>
        /// <param name="source">処理対象文字列。</param>
        /// <returns>処理結果文字列。</returns>
        private string GetAddResult_byForLoop(string source)
        {
            int sum = 0;
            string result = string.Empty;

            // 指定さた文字列の長さが1以上の場合だけ処理。長さゼロの場合は空文字を返す。
            if (source.Length > 0)
            {
                // テキストボックスに文字が入っている場合
                int eachValue = 0;
                // Stringが持つSplitメソッドでカンマごとに配列に格納
                string[] target = source.Split(',');
                // 配列の各要素について足し算しつつ、数式を構成する
                for (int idx = 0; idx < target.Length; idx++)
                {
                    if (int.TryParse(target[idx], out eachValue))
                    {
                        // 加算
                        sum += eachValue;
                        // 計算式文字列に数値を追記する
                        result += target[idx];
                        // 配列の末尾要素以外であればプラス記号を付け足す
                        if (idx!=(target.Length-1)) 
                        {
                            result += " + ";
                        }
                    }
                }
                result += " = " + sum.ToString();
            }
            return result;
        }

        /// <summary>
        /// フォームが閉じられる際の処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNumbersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 自分を隠して、非表示にしてあった親フォームを表示させる
            // どうせクローズするので自分を隠す必要はありませんが、見た目上ちらつくので
            this.Hide();
            this.Owner.Show();
        }
    }
}
