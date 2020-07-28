namespace _10NumberAdd
{
    partial class AddTextBoxNumbersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBoxPanel = new System.Windows.Forms.Panel();
            this.textSource10 = new System.Windows.Forms.TextBox();
            this.textSource09 = new System.Windows.Forms.TextBox();
            this.textSource08 = new System.Windows.Forms.TextBox();
            this.textSource07 = new System.Windows.Forms.TextBox();
            this.textSource06 = new System.Windows.Forms.TextBox();
            this.textSource05 = new System.Windows.Forms.TextBox();
            this.textSource04 = new System.Windows.Forms.TextBox();
            this.textSource03 = new System.Windows.Forms.TextBox();
            this.textSource02 = new System.Windows.Forms.TextBox();
            this.textSource01 = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.TextResult = new System.Windows.Forms.TextBox();
            this.ButtonAdd2 = new System.Windows.Forms.Button();
            this.ButtonAdd3 = new System.Windows.Forms.Button();
            this.ButtonAdd4 = new System.Windows.Forms.Button();
            this.ButtonAdd5 = new System.Windows.Forms.Button();
            this.buttonDescription = new System.Windows.Forms.ToolTip(this.components);
            this.TextBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxPanel
            // 
            this.TextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TextBoxPanel.Controls.Add(this.textSource10);
            this.TextBoxPanel.Controls.Add(this.textSource09);
            this.TextBoxPanel.Controls.Add(this.textSource08);
            this.TextBoxPanel.Controls.Add(this.textSource07);
            this.TextBoxPanel.Controls.Add(this.textSource06);
            this.TextBoxPanel.Controls.Add(this.textSource05);
            this.TextBoxPanel.Controls.Add(this.textSource04);
            this.TextBoxPanel.Controls.Add(this.textSource03);
            this.TextBoxPanel.Controls.Add(this.textSource02);
            this.TextBoxPanel.Controls.Add(this.textSource01);
            this.TextBoxPanel.Location = new System.Drawing.Point(12, 12);
            this.TextBoxPanel.Name = "TextBoxPanel";
            this.TextBoxPanel.Size = new System.Drawing.Size(395, 71);
            this.TextBoxPanel.TabIndex = 0;
            // 
            // textSource10
            // 
            this.textSource10.Location = new System.Drawing.Point(315, 36);
            this.textSource10.Name = "textSource10";
            this.textSource10.Size = new System.Drawing.Size(72, 27);
            this.textSource10.TabIndex = 9;
            // 
            // textSource09
            // 
            this.textSource09.Location = new System.Drawing.Point(237, 36);
            this.textSource09.Name = "textSource09";
            this.textSource09.Size = new System.Drawing.Size(72, 27);
            this.textSource09.TabIndex = 8;
            // 
            // textSource08
            // 
            this.textSource08.Location = new System.Drawing.Point(159, 36);
            this.textSource08.Name = "textSource08";
            this.textSource08.Size = new System.Drawing.Size(72, 27);
            this.textSource08.TabIndex = 7;
            // 
            // textSource07
            // 
            this.textSource07.Location = new System.Drawing.Point(81, 36);
            this.textSource07.Name = "textSource07";
            this.textSource07.Size = new System.Drawing.Size(72, 27);
            this.textSource07.TabIndex = 6;
            // 
            // textSource06
            // 
            this.textSource06.Location = new System.Drawing.Point(3, 36);
            this.textSource06.Name = "textSource06";
            this.textSource06.Size = new System.Drawing.Size(72, 27);
            this.textSource06.TabIndex = 5;
            // 
            // textSource05
            // 
            this.textSource05.Location = new System.Drawing.Point(315, 3);
            this.textSource05.Name = "textSource05";
            this.textSource05.Size = new System.Drawing.Size(72, 27);
            this.textSource05.TabIndex = 4;
            // 
            // textSource04
            // 
            this.textSource04.Location = new System.Drawing.Point(237, 3);
            this.textSource04.Name = "textSource04";
            this.textSource04.Size = new System.Drawing.Size(72, 27);
            this.textSource04.TabIndex = 3;
            // 
            // textSource03
            // 
            this.textSource03.Location = new System.Drawing.Point(159, 3);
            this.textSource03.Name = "textSource03";
            this.textSource03.Size = new System.Drawing.Size(72, 27);
            this.textSource03.TabIndex = 2;
            // 
            // textSource02
            // 
            this.textSource02.Location = new System.Drawing.Point(81, 3);
            this.textSource02.Name = "textSource02";
            this.textSource02.Size = new System.Drawing.Size(72, 27);
            this.textSource02.TabIndex = 1;
            // 
            // textSource01
            // 
            this.textSource01.Location = new System.Drawing.Point(3, 3);
            this.textSource01.Name = "textSource01";
            this.textSource01.Size = new System.Drawing.Size(72, 27);
            this.textSource01.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 89);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(120, 32);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "足し算1";
            this.buttonDescription.SetToolTip(this.ButtonAdd, "情報取得はLINQ、出力はforeachを使うパターン");
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(8, 170);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(39, 19);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "結果";
            // 
            // TextResult
            // 
            this.TextResult.Location = new System.Drawing.Point(12, 192);
            this.TextResult.Name = "TextResult";
            this.TextResult.Size = new System.Drawing.Size(395, 27);
            this.TextResult.TabIndex = 4;
            // 
            // ButtonAdd2
            // 
            this.ButtonAdd2.Location = new System.Drawing.Point(138, 89);
            this.ButtonAdd2.Name = "ButtonAdd2";
            this.ButtonAdd2.Size = new System.Drawing.Size(120, 32);
            this.ButtonAdd2.TabIndex = 6;
            this.ButtonAdd2.Text = "足し算2";
            this.buttonDescription.SetToolTip(this.ButtonAdd2, "全部LINQで計算するパターン(1)");
            this.ButtonAdd2.UseVisualStyleBackColor = true;
            this.ButtonAdd2.Click += new System.EventHandler(this.ButtonAdd2_Click);
            // 
            // ButtonAdd3
            // 
            this.ButtonAdd3.Location = new System.Drawing.Point(264, 89);
            this.ButtonAdd3.Name = "ButtonAdd3";
            this.ButtonAdd3.Size = new System.Drawing.Size(120, 32);
            this.ButtonAdd3.TabIndex = 7;
            this.ButtonAdd3.Text = "足し算3";
            this.buttonDescription.SetToolTip(this.ButtonAdd3, "全部LINQで計算するパターン(2)");
            this.ButtonAdd3.UseVisualStyleBackColor = true;
            this.ButtonAdd3.Click += new System.EventHandler(this.ButtonAdd3_Click);
            // 
            // ButtonAdd4
            // 
            this.ButtonAdd4.Location = new System.Drawing.Point(390, 89);
            this.ButtonAdd4.Name = "ButtonAdd4";
            this.ButtonAdd4.Size = new System.Drawing.Size(120, 32);
            this.ButtonAdd4.TabIndex = 8;
            this.ButtonAdd4.Text = "足し算4";
            this.buttonDescription.SetToolTip(this.ButtonAdd4, "全部LINQで計算するパターン(4)");
            this.ButtonAdd4.UseVisualStyleBackColor = true;
            this.ButtonAdd4.Click += new System.EventHandler(this.ButtonAdd4_Click);
            // 
            // ButtonAdd5
            // 
            this.ButtonAdd5.Location = new System.Drawing.Point(12, 127);
            this.ButtonAdd5.Name = "ButtonAdd5";
            this.ButtonAdd5.Size = new System.Drawing.Size(120, 32);
            this.ButtonAdd5.TabIndex = 9;
            this.ButtonAdd5.Text = "足し算5";
            this.buttonDescription.SetToolTip(this.ButtonAdd5, "LINQで極力行数を減らしてみたパターン");
            this.ButtonAdd5.UseVisualStyleBackColor = true;
            this.ButtonAdd5.Click += new System.EventHandler(this.ButtonAdd5_Click);
            // 
            // AddTextBoxNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 231);
            this.Controls.Add(this.ButtonAdd5);
            this.Controls.Add(this.ButtonAdd4);
            this.Controls.Add(this.ButtonAdd3);
            this.Controls.Add(this.ButtonAdd2);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.TextResult);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxPanel);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTextBoxNumbersForm";
            this.Text = "AddTextBoxNumbersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNumbersForm_FormClosed);
            this.TextBoxPanel.ResumeLayout(false);
            this.TextBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TextBoxPanel;
        private System.Windows.Forms.TextBox textSource10;
        private System.Windows.Forms.TextBox textSource09;
        private System.Windows.Forms.TextBox textSource08;
        private System.Windows.Forms.TextBox textSource07;
        private System.Windows.Forms.TextBox textSource06;
        private System.Windows.Forms.TextBox textSource05;
        private System.Windows.Forms.TextBox textSource04;
        private System.Windows.Forms.TextBox textSource03;
        private System.Windows.Forms.TextBox textSource02;
        private System.Windows.Forms.TextBox textSource01;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox TextResult;
        private System.Windows.Forms.Button ButtonAdd2;
        private System.Windows.Forms.Button ButtonAdd3;
        private System.Windows.Forms.Button ButtonAdd4;
        private System.Windows.Forms.Button ButtonAdd5;
        private System.Windows.Forms.ToolTip buttonDescription;
    }
}