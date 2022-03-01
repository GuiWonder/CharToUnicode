namespace CharToUnicode
{
    partial class FormMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxUnicode = new System.Windows.Forms.TextBox();
            this.checkBoxReturn = new System.Windows.Forms.CheckBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxSpace = new System.Windows.Forms.CheckBox();
            this.checkBoxTab = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUnicode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonConvert, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxChar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxUnicode
            // 
            this.textBoxUnicode.AcceptsReturn = true;
            this.textBoxUnicode.AcceptsTab = true;
            this.textBoxUnicode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUnicode.Location = new System.Drawing.Point(295, 3);
            this.textBoxUnicode.Multiline = true;
            this.textBoxUnicode.Name = "textBoxUnicode";
            this.textBoxUnicode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUnicode.Size = new System.Drawing.Size(286, 336);
            this.textBoxUnicode.TabIndex = 1;
            // 
            // checkBoxReturn
            // 
            this.checkBoxReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxReturn.AutoSize = true;
            this.checkBoxReturn.Location = new System.Drawing.Point(6, 4);
            this.checkBoxReturn.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxReturn.Name = "checkBoxReturn";
            this.checkBoxReturn.Size = new System.Drawing.Size(85, 20);
            this.checkBoxReturn.TabIndex = 2;
            this.checkBoxReturn.Text = "转换换行符";
            this.checkBoxReturn.UseCompatibleTextRendering = true;
            this.checkBoxReturn.UseVisualStyleBackColor = true;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConvert.Location = new System.Drawing.Point(400, 345);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "转换";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // textBoxChar
            // 
            this.textBoxChar.AcceptsReturn = true;
            this.textBoxChar.AcceptsTab = true;
            this.textBoxChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChar.Location = new System.Drawing.Point(3, 3);
            this.textBoxChar.Multiline = true;
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChar.Size = new System.Drawing.Size(286, 336);
            this.textBoxChar.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33533F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxReturn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxSpace, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxTab, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 342);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(292, 29);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // checkBoxSpace
            // 
            this.checkBoxSpace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSpace.AutoSize = true;
            this.checkBoxSpace.Location = new System.Drawing.Point(109, 6);
            this.checkBoxSpace.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSpace.Name = "checkBoxSpace";
            this.checkBoxSpace.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSpace.TabIndex = 3;
            this.checkBoxSpace.Text = "转换空格";
            this.checkBoxSpace.UseVisualStyleBackColor = true;
            // 
            // checkBoxTab
            // 
            this.checkBoxTab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxTab.AutoSize = true;
            this.checkBoxTab.Location = new System.Drawing.Point(201, 6);
            this.checkBoxTab.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxTab.Name = "checkBoxTab";
            this.checkBoxTab.Size = new System.Drawing.Size(84, 16);
            this.checkBoxTab.TabIndex = 4;
            this.checkBoxTab.Text = "转换制表符";
            this.checkBoxTab.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.Text = "Unicode";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxUnicode;
        private System.Windows.Forms.CheckBox checkBoxReturn;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxSpace;
        private System.Windows.Forms.CheckBox checkBoxTab;
    }
}

