using System;
using System.Windows.Forms;

namespace CS_LoopAndArraySample
{
    public partial class CreateKukuList : Form
    {
        // フォーム上への表示だけであれば配列を利用する必要はありませんが、
        // 現実のシステムでは「九九一覧の作成を依頼して、結果を別のコンピューターに送る」といった
        // 場面が多く発生し、そのときに「作った情報を入れる入れ物」を用意することがあります。
        // ここで敢えて、ボタンクリックなどでそのままテキストボックスに情報を表示するのではなく、
        // いったん配列に入れてメソッドの戻り値として返しているのはそうしたケースに対応出来る練習のためです。

        public CreateKukuList()
        {
            InitializeComponent();
        }

        // 九九の表示
        // ・処理は以下の2処理に分割しました
        //   1. 九九を二次元配列に入れて返す関数
        // 　2. 二次元整数配列を渡すと整形して文字列にする関数


        /// <summary>
        /// 九九作成ボタン押下処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void ButtonKuku_Click(object sender, EventArgs e)
        {
            // 二次元整数配列に、GetKukuMatrixの処理結果(9x9の二次元整数配列)を代入する
            int[,] kukuMatrix = GetKukuMatrix();

            // 結果をテキストボックスに表示
            TextKuku.Text = ShowKukuList(kukuMatrix);

            // 参考：下記の1行のようにも書けます。
            //TextKuku.Text = ShowKukuList(GetKukuMatrix());

        }


        /// <summary>
        /// 9x9の二次元配列に九九の計算結果を入れて返す。
        /// </summary>
        /// <returns>九九の計算結果を入れたint[9x9]の配列。</returns>
        private int[,] GetKukuMatrix()
        {
            // 可変版の九九一覧作成関数をサイズ9で呼び出して返す。
            return GetKukuMatrix(9);
        }


        /// <summary>
        /// n x nの二次元配列に九九のような計算結果を入れて返す。
        /// GetKuKuMatrixの可変サイズ版。
        /// </summary>
        /// <remarks>
        /// あとで出てきますが、同じ名称で引数違いの関数を宣言することを、
        /// オーバーロード（overload）と呼びます。
        /// </remarks>
        /// <param name="matrixSize"></param>
        /// <returns></returns>
        private int[,] GetKukuMatrix(int matrixSize)
        {
            int[,] result = new int[matrixSize, matrixSize];

            // 外側のループでは「iの段」を表現
            for (int i = 0; i < matrixSize; i++)
            {
                // 内側のループでは「iの段」の1～9を表現
                for (int j = 0; j < matrixSize; j++)
                {
                    // 掛け算した結果を「i行」の「j列」に設定する
                    result[i, j] = (j + 1) * (i + 1);
                }
            }
            return result;            
        }


        /// <summary>
        /// 二次元の整数配列を渡すと、空白区切りの表形式文字列にして返す。
        /// </summary>
        /// <param name="kukuMatrix">表示したい二次元整数配列。</param>
        /// <returns>二次元整数配列を、3桁右寄せで表形式に並べた文字列。行末には\r\nで改行を入れてある。</returns>
        private string ShowKukuList(int[,] kukuMatrix)
        {
            // 結果用文字列としてresult変数を用意
            string result = string.Empty;

            // 縦横サイズをそれぞれouter、innerとして用意する
            int outerSize = kukuMatrix.GetLength(0);
            int innerSize = kukuMatrix.GetLength(1);

            // 二重のループで二次元配列を順に走査する
            for (int i = 0; i < outerSize; i++)
            {
                for (int j = 0; j < innerSize; j++)
                {
                    // 結果文字列に、配列中の「i行、j列」の内容を「3桁右寄せ＋空白2個」に整形して追加。
                    result += string.Format("{0,3}  ", kukuMatrix[i, j]);
                }
                // 行の終わりで改行を加える
                result += "\r\n";
            }
            return result;
        }

    }
}
