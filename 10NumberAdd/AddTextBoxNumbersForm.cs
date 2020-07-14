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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // 数値入力用テキストボックスを「Panel」に貼り付けて、その中にある部品が入った
            // Panel.Controlsに対して「TextBox型のものだけを洗い出してsourcesに入れろ」という
            // 命令を実行する。
            IEnumerable<TextBox> sources = TextBoxPanel.Controls.OfType<TextBox>();

            //// 同じことをLINQのWhereでやるには下記のようにする必要があります。OfTypeの方がシンプルですね
            // IEnumerable<TextBox> sources = TextBoxPanel.Controls.Cast<Control>().Where(x => x is TextBox).Select(x => (TextBox)x);


            // ※TextBoxはパネルに入れなくても良いですが、たとえば「計算に使わないテキストボックスもある」といった場合、
            // 計算に使うものだけをパネルに入れて仕分けするといった使い方もあるのでここではパネルコントロールに
            // 貼り付けています。

            // ※OfTypeでTextBoxだけをより分けているのも、TextBox以外が存在する場合に備えて、です。
            // なので、フォーム上に計算に使うテキストボックスしか無い、といった場合は特に型の指定などをせずに
            // 全部のコントロールを対象に処理しても良いかも知れません。


            // IEnumerable<TextBox>という型の、テキストボックスだけが入った集合に対して、
            // 「中身をTextBox型の配列にしろ」という命令を実行してTextBox配列を取得する。
            // 順番がどうやら見た目と逆転するようなので、OrderByを使ってテキストボックスの名前で並べ替えています
            TextBox[] sourcesArray = sources.OrderBy<TextBox, string>(x => x.Name).ToArray<TextBox>();

            //// ■LINQで計算するパターン(1)
            //// 数字以外の混入に備えない、楽観的な変換で計算するパターン
            //int result = sourcesArray.Sum<TextBox>(x => int.Parse(x.Text));
            //TextResult.Text = result.ToString();

            //// ■LINQで計算するパターン(2)
            //// 最初にTryParse結果がTrueになるものだけをより分け、その後Sumで加算。Array.ForEachで加算式を作り、
            //// 表示の直前で末尾だけ =に置き換えて結果を書き足しています。
            //sourcesArray = sourcesArray.Where(y => int.TryParse(y.Text, out int value)).ToArray<TextBox>();
            //int result = sourcesArray.Sum<TextBox>(x => int.Parse(x.Text));
            //string resultString = string.Empty;
            //Array.ForEach(sourcesArray, x => resultString += x.Text + " + ");
            //TextResult.Text = (resultString + "_").Replace(" + _", " = ") + result.ToString();

            //// ■LINQで計算するパターン(3)
            //// TryParse成功するもののより分けを事前に行わずにおなじことを実施したパターン
            //int result = sourcesArray.Sum<TextBox>(x => { if (int.TryParse(x.Text, out int value)) return value; else return 0; });
            //string resultString = string.Empty;
            //Array.ForEach(sourcesArray.Where(y => int.TryParse(y.Text, out int value)).ToArray<TextBox>(), x => resultString += x.Text + " + ");
            //TextResult.Text = (resultString + "_").Replace(" + _", " = ") + result.ToString();

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
