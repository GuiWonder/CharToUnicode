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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxReturn = new System.Windows.Forms.CheckBox();
            this.checkBoxSpace = new System.Windows.Forms.CheckBox();
            this.checkBoxTab = new System.Windows.Forms.CheckBox();
            this.textBoxUnicode = new System.Windows.Forms.TextBox();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.checkBoxUppercase = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUnicode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxChar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 371);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 336);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(342, 35);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // checkBoxReturn
            // 
            this.checkBoxReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxReturn.AutoSize = true;
            this.checkBoxReturn.Checked = true;
            this.checkBoxReturn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReturn.Location = new System.Drawing.Point(1, 7);
            this.checkBoxReturn.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxReturn.Name = "checkBoxReturn";
            this.checkBoxReturn.Size = new System.Drawing.Size(110, 20);
            this.checkBoxReturn.TabIndex = 2;
            this.checkBoxReturn.Text = "Ignore newlines";
            this.checkBoxReturn.UseCompatibleTextRendering = true;
            this.checkBoxReturn.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpace
            // 
            this.checkBoxSpace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSpace.AutoSize = true;
            this.checkBoxSpace.Checked = true;
            this.checkBoxSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSpace.Location = new System.Drawing.Point(118, 9);
            this.checkBoxSpace.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSpace.Name = "checkBoxSpace";
            this.checkBoxSpace.Size = new System.Drawing.Size(102, 16);
            this.checkBoxSpace.TabIndex = 3;
            this.checkBoxSpace.Text = "Ignore spaces";
            this.checkBoxSpace.UseVisualStyleBackColor = true;
            // 
            // checkBoxTab
            // 
            this.checkBoxTab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxTab.AutoSize = true;
            this.checkBoxTab.Checked = true;
            this.checkBoxTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTab.Location = new System.Drawing.Point(239, 9);
            this.checkBoxTab.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxTab.Name = "checkBoxTab";
            this.checkBoxTab.Size = new System.Drawing.Size(90, 16);
            this.checkBoxTab.TabIndex = 4;
            this.checkBoxTab.Text = "Ignore tabs";
            this.checkBoxTab.UseVisualStyleBackColor = true;
            // 
            // textBoxUnicode
            // 
            this.textBoxUnicode.AcceptsReturn = true;
            this.textBoxUnicode.AcceptsTab = true;
            this.textBoxUnicode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUnicode.Location = new System.Drawing.Point(345, 23);
            this.textBoxUnicode.Multiline = true;
            this.textBoxUnicode.Name = "textBoxUnicode";
            this.textBoxUnicode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUnicode.Size = new System.Drawing.Size(336, 310);
            this.textBoxUnicode.TabIndex = 1;
            // 
            // textBoxChar
            // 
            this.textBoxChar.AcceptsReturn = true;
            this.textBoxChar.AcceptsTab = true;
            this.textBoxChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChar.Location = new System.Drawing.Point(3, 23);
            this.textBoxChar.Multiline = true;
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChar.Size = new System.Drawing.Size(336, 310);
            this.textBoxChar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "String:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unicode:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.checkBoxUppercase);
            this.panel1.Controls.Add(this.textBoxPrefix);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(345, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 29);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prefix:";
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Location = new System.Drawing.Point(134, 5);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(100, 21);
            this.textBoxPrefix.TabIndex = 1;
            this.textBoxPrefix.Text = "\\u";
            // 
            // checkBoxUppercase
            // 
            this.checkBoxUppercase.AutoSize = true;
            this.checkBoxUppercase.Location = new System.Drawing.Point(3, 7);
            this.checkBoxUppercase.Name = "checkBoxUppercase";
            this.checkBoxUppercase.Size = new System.Drawing.Size(78, 16);
            this.checkBoxUppercase.TabIndex = 3;
            this.checkBoxUppercase.Text = "Uppercase";
            this.checkBoxUppercase.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.Text = "Unicode";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxUnicode;
        private System.Windows.Forms.CheckBox checkBoxReturn;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxSpace;
        private System.Windows.Forms.CheckBox checkBoxTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxUppercase;
    }
}

