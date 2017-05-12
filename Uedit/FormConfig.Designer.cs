namespace Uedit
{
    partial class FormConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPageSize = new System.Windows.Forms.ComboBox();
            this.cmbMarginTop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMarginBottom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarginLeft = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMarginRight = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbPageCount = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "纸张规格：";
            // 
            // cmbPageSize
            // 
            this.cmbPageSize.FormattingEnabled = true;
            this.cmbPageSize.Items.AddRange(new object[] {
            "宋体",
            "楷体"});
            this.cmbPageSize.Location = new System.Drawing.Point(101, 9);
            this.cmbPageSize.Name = "cmbPageSize";
            this.cmbPageSize.Size = new System.Drawing.Size(121, 20);
            this.cmbPageSize.TabIndex = 1;
            // 
            // cmbMarginTop
            // 
            this.cmbMarginTop.FormattingEnabled = true;
            this.cmbMarginTop.Items.AddRange(new object[] {
            "1.5",
            "2.0",
            "2.5"});
            this.cmbMarginTop.Location = new System.Drawing.Point(101, 84);
            this.cmbMarginTop.Name = "cmbMarginTop";
            this.cmbMarginTop.Size = new System.Drawing.Size(121, 20);
            this.cmbMarginTop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "上边距：";
            // 
            // cmbMarginBottom
            // 
            this.cmbMarginBottom.FormattingEnabled = true;
            this.cmbMarginBottom.Items.AddRange(new object[] {
            "1.5",
            "2.0",
            "2.5"});
            this.cmbMarginBottom.Location = new System.Drawing.Point(101, 121);
            this.cmbMarginBottom.Name = "cmbMarginBottom";
            this.cmbMarginBottom.Size = new System.Drawing.Size(121, 20);
            this.cmbMarginBottom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "下边距：";
            // 
            // cmbMarginLeft
            // 
            this.cmbMarginLeft.FormattingEnabled = true;
            this.cmbMarginLeft.Items.AddRange(new object[] {
            "1.5",
            "2.0",
            "2.5"});
            this.cmbMarginLeft.Location = new System.Drawing.Point(101, 159);
            this.cmbMarginLeft.Name = "cmbMarginLeft";
            this.cmbMarginLeft.Size = new System.Drawing.Size(121, 20);
            this.cmbMarginLeft.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "左边距：";
            // 
            // cmbMarginRight
            // 
            this.cmbMarginRight.FormattingEnabled = true;
            this.cmbMarginRight.Items.AddRange(new object[] {
            "1.5",
            "2.0",
            "2.5"});
            this.cmbMarginRight.Location = new System.Drawing.Point(101, 198);
            this.cmbMarginRight.Name = "cmbMarginRight";
            this.cmbMarginRight.Size = new System.Drawing.Size(121, 20);
            this.cmbMarginRight.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "右边距：";
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "cm",
            "mm"});
            this.cmbUnit.Location = new System.Drawing.Point(101, 47);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 20);
            this.cmbUnit.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(13, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "页边距单位：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(387, 231);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Items.AddRange(new object[] {
            "cm",
            "mm"});
            this.cmbFontSize.Location = new System.Drawing.Point(341, 47);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(121, 20);
            this.cmbFontSize.TabIndex = 18;
            this.cmbFontSize.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(253, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "字体大小：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1.5",
            "2.0",
            "2.5"});
            this.comboBox2.Location = new System.Drawing.Point(341, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.Text = "1";
            // 
            // cmbPageCount
            // 
            this.cmbPageCount.AutoSize = true;
            this.cmbPageCount.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPageCount.Location = new System.Drawing.Point(253, 88);
            this.cmbPageCount.Name = "cmbPageCount";
            this.cmbPageCount.Size = new System.Drawing.Size(67, 14);
            this.cmbPageCount.TabIndex = 15;
            this.cmbPageCount.Text = "总页数：";
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Items.AddRange(new object[] {
            "宋体",
            "楷体"});
            this.cmbFont.Location = new System.Drawing.Point(341, 9);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 20);
            this.cmbFont.TabIndex = 14;
            this.cmbFont.Text = "宋体";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(253, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "字体：";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 266);
            this.Controls.Add(this.cmbFontSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbPageCount);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMarginRight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMarginLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMarginBottom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMarginTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPageSize);
            this.Controls.Add(this.label1);
            this.Name = "FormConfig";
            this.Text = "页面设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPageSize;
        private System.Windows.Forms.ComboBox cmbMarginTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMarginBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarginLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMarginRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label cmbPageCount;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Label label9;
    }
}