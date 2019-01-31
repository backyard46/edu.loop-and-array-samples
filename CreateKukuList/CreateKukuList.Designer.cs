namespace CS_LoopAndArraySample
{
    partial class CreateKukuList
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonKuku = new System.Windows.Forms.Button();
            this.TextKuku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonKuku
            // 
            this.ButtonKuku.Location = new System.Drawing.Point(632, 16);
            this.ButtonKuku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonKuku.Name = "ButtonKuku";
            this.ButtonKuku.Size = new System.Drawing.Size(144, 36);
            this.ButtonKuku.TabIndex = 0;
            this.ButtonKuku.Text = "九九リスト作成";
            this.ButtonKuku.UseVisualStyleBackColor = true;
            this.ButtonKuku.Click += new System.EventHandler(this.ButtonKuku_Click);
            // 
            // TextKuku
            // 
            this.TextKuku.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextKuku.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextKuku.Location = new System.Drawing.Point(0, 64);
            this.TextKuku.Multiline = true;
            this.TextKuku.Name = "TextKuku";
            this.TextKuku.Size = new System.Drawing.Size(792, 420);
            this.TextKuku.TabIndex = 1;
            // 
            // CreateKukuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 484);
            this.Controls.Add(this.TextKuku);
            this.Controls.Add(this.ButtonKuku);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateKukuList";
            this.Text = "ループと配列";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonKuku;
        protected System.Windows.Forms.TextBox TextKuku;
    }
}

