namespace Wen.OurOfficeConverter.WinForm.Main
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenWordConverter = new System.Windows.Forms.Button();
            this.btnOpenExcelConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenWordConverter
            // 
            this.btnOpenWordConverter.Location = new System.Drawing.Point(12, 12);
            this.btnOpenWordConverter.Name = "btnOpenWordConverter";
            this.btnOpenWordConverter.Size = new System.Drawing.Size(260, 23);
            this.btnOpenWordConverter.TabIndex = 0;
            this.btnOpenWordConverter.Text = "打开 Word 转换器";
            this.btnOpenWordConverter.UseVisualStyleBackColor = true;
            this.btnOpenWordConverter.Click += new System.EventHandler(this.btnOpenWordConverter_Click);
            // 
            // btnOpenExcelConverter
            // 
            this.btnOpenExcelConverter.Location = new System.Drawing.Point(12, 41);
            this.btnOpenExcelConverter.Name = "btnOpenExcelConverter";
            this.btnOpenExcelConverter.Size = new System.Drawing.Size(260, 23);
            this.btnOpenExcelConverter.TabIndex = 1;
            this.btnOpenExcelConverter.Text = "打开 Excel 转换器";
            this.btnOpenExcelConverter.UseVisualStyleBackColor = true;
            this.btnOpenExcelConverter.Click += new System.EventHandler(this.btnOpenExcelConverter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 74);
            this.Controls.Add(this.btnOpenExcelConverter);
            this.Controls.Add(this.btnOpenWordConverter);
            this.Name = "MainForm";
            this.Text = "转换器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenWordConverter;
        private System.Windows.Forms.Button btnOpenExcelConverter;
    }
}

