using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _10NumberAdd
{
    public partial class AddTextBoxNumbersForm : Form
    {
        public AddTextBoxNumbersForm()
        {
            InitializeComponent();
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


        /// <summary>
        /// ■情報取得はLINQ、出力はforeachを使うパターン
        /// OfTypeとLINQを使ってTextBox配列を作り、foreachで結果を生成する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // ※TextBoxはパネルに入れなくても良いですが、たとえば「計算に使わないテキストボックスもある」といった場合、
            // 計算に使うものだけをパネルに入れて仕分けするといった使い方もあるのでここではパネルコントロールに
            // 貼り付けています。

            // ※OfTypeでTextBoxだけをより分けているのも、TextBox以外が存在する場合に備えて、です。
            // なので、フォーム上に計算に使うテキストボックスしか無い、といった場合は特に型の指定などをせずに
            // 全部のコントロールを対象に処理しても良いかも知れません。


            // 数値入力用テキストボックスを「Panel」に貼り付けて、その中にある部品が入った
            // Panel.Controlsに対して「TextBox型のものだけを洗い出してsourcesに入れろ」という
            // 命令を実行する。
            IEnumerable<TextBox> sources = TextBoxPanel.Controls.OfType<TextBox>();

            // IEnumerable<TextBox>という型の、テキストボックスだけが入った集合に対して、
            // 「中身をTextBox型の配列にしろ」という命令を実行してTextBox配列を取得する。
            // 順番がどうやら見た目と逆転するようなので、OrderByを使ってテキストボックスの名前で並べ替えています
            TextBox[] sourcesArray = sources.OrderBy<TextBox, string>(x => x.Name).ToArray<TextBox>();

            // ■foreachでループさせてTryParseでintに出来るものだけを計算するパターン
            int result = 0;
            string resultString = string.Empty;
            foreach (TextBox x in sourcesArray)
            {
                if (int.TryParse(x.Text, out int value))
                {
                    result += value;
                    resultString += x.Text + " + ";
                }
            }
            // 末尾の「 + 」を「 = 」に書き換える（末尾を特定するためにアンダースコアを足しています）。
            resultString = (resultString + "_").Replace("+ _", "= ") + result.ToString();
            TextResult.Text = resultString;
        }


        /// <summary>
        /// ■全部LINQで計算するパターン(1)
        /// 数字以外の混入に備えない、楽観的な変換で計算するパターン。文字とか入ったらエラーです。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd2_Click(object sender, EventArgs e)
        {
            // ButtonAdd_Clickと同様のことをLINQのWhereを使ってやってみています。
            IEnumerable<TextBox> sources = TextBoxPanel.Controls.Cast<Control>().Where(x => x is TextBox).Select(x => (TextBox)x);

            // ButtonAdd_Clickと同様。
            // IEnumerable<TextBox>という型に「中身をTextBox型の配列にしろ」という命令を実行してTextBox配列を取得する。
            TextBox[] sourcesArray = sources.OrderBy<TextBox, string>(x => x.Name).ToArray<TextBox>();

            // LINQのSumを使って計算
            int result = sourcesArray.Sum<TextBox>(x => int.Parse(x.Text));
            string resultString = string.Empty;
            Array.ForEach(sourcesArray, x => resultString += x.Text + " + ");
            TextResult.Text = resultString;
        }


        /// <summary>
        /// ■全部LINQで計算するパターン(2)
        /// 合計、出力それぞれでTryParseをLINQのラムダ式に仕込むパターン。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd3_Click(object sender, EventArgs e)
        {
            // ButtonAdd_Clickと同様。
            // Panel.Controlsに対して「TextBox型のものだけを洗い出してsourcesに入れろ」という命令を実行する。
            IEnumerable<TextBox> sources = TextBoxPanel.Controls.OfType<TextBox>();

            // ButtonAdd_Clickと同様。
            // IEnumerable<TextBox>という型に「中身をTextBox型の配列にしろ」という命令を実行してTextBox配列を取得する。
            TextBox[] sourcesArray = sources.OrderBy<TextBox, string>(x => x.Name).ToArray<TextBox>();

            // Sum、Array.ForeachそれぞれでTryParseによるチェックを行いつつ、計算と文字列生成を行います。
            int result = sourcesArray.Sum<TextBox>(x => { if (int.TryParse(x.Text, out int value)) return value; else return 0; });
            string resultString = string.Empty;
            Array.ForEach(sourcesArray.Where(y => int.TryParse(y.Text, out int value)).ToArray<TextBox>(), x => resultString += x.Text + " + ");
            TextResult.Text = (resultString + "_").Replace(" + _", " = ") + result.ToString();
        }


        /// <summary>
        /// ■全部LINQで計算するパターン(4)
        /// 事前にTryParseに成功するものだけの配列にしてから処理するパターン。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd4_Click(object sender, EventArgs e)
        {
            // ButtonAdd_Clickと同様。
            // Panel.Controlsに対して「TextBox型のものだけを洗い出してsourcesに入れろ」という命令を実行する。
            IEnumerable<TextBox> sources = TextBoxPanel.Controls.OfType<TextBox>();

            // ButtonAdd_Clickと同様。
            // IEnumerable<TextBox>という型に「中身をTextBox型の配列にしろ」という命令を実行してTextBox配列を取得する。
            TextBox[] sourcesArray = sources.OrderBy<TextBox, string>(x => x.Name).ToArray<TextBox>();

            // 最初にTryParse結果がTrueになるものだけをより分け、その後Sumで加算。Array.ForEachで加算式を作り、
            // 表示の直前で末尾だけ =に置き換えて結果を書き足しています。
            sourcesArray = sourcesArray.Where(y => int.TryParse(y.Text, out int value)).ToArray<TextBox>();
            int result = sourcesArray.Sum<TextBox>(x => int.Parse(x.Text));
            string resultString = string.Empty;
            Array.ForEach(sourcesArray, x => resultString += x.Text + " + ");
            TextResult.Text = (resultString + "_").Replace(" + _", " = ") + result.ToString();
        }


        /// <summary>
        /// ■LINQで極力行数を減らしてみたパターン
        /// ButtonAdd4と同様の処理を極力行数を減らしてみたパターン。動きますが、こういうのは止めた方がいいです。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd5_Click(object sender, EventArgs e)
        {
            TextBox[] sourcesArray = TextBoxPanel.Controls.OfType<TextBox>().OrderBy<TextBox, string>(x => x.Name).ToArray<TextBox>().Where(y => int.TryParse(y.Text, out int value)).ToArray<TextBox>();
            Array.ForEach(sourcesArray, x => TextResult.Text += x.Text + " + ");
            TextResult.Text = (TextResult.Text + "_").Replace(" + _", " = ") + sourcesArray.Sum<TextBox>(x => int.Parse(x.Text)).ToString();
        }
    }
}
