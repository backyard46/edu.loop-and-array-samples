namespace _10NumberAdd
{
    partial class Menu
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
            this.kadai1Button = new System.Windows.Forms.Button();
            this.kadai4Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kadai1Button
            // 
            this.kadai1Button.Location = new System.Drawing.Point(12, 12);
            this.kadai1Button.Name = "kadai1Button";
            this.kadai1Button.Size = new System.Drawing.Size(238, 41);
            this.kadai1Button.TabIndex = 0;
            this.kadai1Button.Text = "課題1（10個のテキストボックス）";
            this.kadai1Button.UseVisualStyleBackColor = true;
            this.kadai1Button.Click += new System.EventHandler(this.kadai1Button_Click);
            // 
            // kadai4Button
            // 
            this.kadai4Button.Location = new System.Drawing.Point(12, 59);
            this.kadai4Button.Name = "kadai4Button";
            this.kadai4Button.Size = new System.Drawing.Size(238, 41);
            this.kadai4Button.TabIndex = 1;
            this.kadai4Button.Text = "課題4（カンマ区切り数値の加算）";
            this.kadai4Button.UseVisualStyleBackColor = true;
            this.kadai4Button.Click += new System.EventHandler(this.kadai4Button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 111);
            this.Controls.Add(this.kadai4Button);
            this.Controls.Add(this.kadai1Button);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kadai1Button;
        private System.Windows.Forms.Button kadai4Button;
    }
}