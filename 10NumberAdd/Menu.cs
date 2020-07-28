using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10NumberAdd
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 課題006-1のフォームを開く。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kadai1Button_Click(object sender, EventArgs e)
        {
            AddTextBoxNumbersForm nextForm = new AddTextBoxNumbersForm();
            this.Hide();
            nextForm.Show(this);
        }

        /// <summary>
        /// 課題006-4のフォームを開く。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kadai4Button_Click(object sender, EventArgs e)
        {
            AddNumbersForm nextForm = new AddNumbersForm();
            this.Hide();
            nextForm.Show(this);
        }
    }
}
