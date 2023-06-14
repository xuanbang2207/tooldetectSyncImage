namespace ToolDetectCropSyncImage
{
    partial class Form1
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
            this.lblExcelPath = new System.Windows.Forms.Label();
            this.lblSheetName = new System.Windows.Forms.Label();
            this.lblFolderImage = new System.Windows.Forms.Label();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.txtFolderImage = new System.Windows.Forms.TextBox();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnFolderImage = new System.Windows.Forms.Button();
            this.checklbColumn = new System.Windows.Forms.CheckedListBox();
            this.picbImage1 = new System.Windows.Forms.PictureBox();
            this.cbSheetName = new System.Windows.Forms.ComboBox();
            this.grbImageForm = new System.Windows.Forms.GroupBox();
            this.radEmpCode = new System.Windows.Forms.RadioButton();
            this.radAccountName = new System.Windows.Forms.RadioButton();
            this.grbNumberImage = new System.Windows.Forms.GroupBox();
            this.rad5Image = new System.Windows.Forms.RadioButton();
            this.rad1Image = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.picbImage2 = new System.Windows.Forms.PictureBox();
            this.picImage3 = new System.Windows.Forms.PictureBox();
            this.picbImage4 = new System.Windows.Forms.PictureBox();
            this.picbImage5 = new System.Windows.Forms.PictureBox();
            this.grbCrop = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.grbBase64 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblImageCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage1)).BeginInit();
            this.grbImageForm.SuspendLayout();
            this.grbNumberImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage5)).BeginInit();
            this.grbCrop.SuspendLayout();
            this.grbBase64.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExcelPath
            // 
            this.lblExcelPath.AutoSize = true;
            this.lblExcelPath.Location = new System.Drawing.Point(3, 27);
            this.lblExcelPath.Name = "lblExcelPath";
            this.lblExcelPath.Size = new System.Drawing.Size(84, 13);
            this.lblExcelPath.TabIndex = 0;
            this.lblExcelPath.Text = "Import File Excel";
            // 
            // lblSheetName
            // 
            this.lblSheetName.AutoSize = true;
            this.lblSheetName.Location = new System.Drawing.Point(3, 67);
            this.lblSheetName.Name = "lblSheetName";
            this.lblSheetName.Size = new System.Drawing.Size(66, 13);
            this.lblSheetName.TabIndex = 0;
            this.lblSheetName.Text = "Sheet Name";
            this.lblSheetName.Click += new System.EventHandler(this.lblSheetName_Click);
            // 
            // lblFolderImage
            // 
            this.lblFolderImage.AutoSize = true;
            this.lblFolderImage.Location = new System.Drawing.Point(3, 292);
            this.lblFolderImage.Name = "lblFolderImage";
            this.lblFolderImage.Size = new System.Drawing.Size(100, 13);
            this.lblFolderImage.TabIndex = 0;
            this.lblFolderImage.Text = "Import Folder Image";
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Location = new System.Drawing.Point(106, 24);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(212, 20);
            this.txtExcelPath.TabIndex = 1;
            // 
            // txtFolderImage
            // 
            this.txtFolderImage.Location = new System.Drawing.Point(106, 292);
            this.txtFolderImage.Name = "txtFolderImage";
            this.txtFolderImage.Size = new System.Drawing.Size(212, 20);
            this.txtFolderImage.TabIndex = 1;
            this.txtFolderImage.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(340, 22);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(120, 23);
            this.btnImportExcel.TabIndex = 2;
            this.btnImportExcel.Text = "Browser";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnFolderImage
            // 
            this.btnFolderImage.Location = new System.Drawing.Point(340, 292);
            this.btnFolderImage.Name = "btnFolderImage";
            this.btnFolderImage.Size = new System.Drawing.Size(120, 23);
            this.btnFolderImage.TabIndex = 2;
            this.btnFolderImage.Text = "Browser";
            this.btnFolderImage.UseVisualStyleBackColor = true;
            this.btnFolderImage.Click += new System.EventHandler(this.btnFolderImage_Click);
            // 
            // checklbColumn
            // 
            this.checklbColumn.FormattingEnabled = true;
            this.checklbColumn.Location = new System.Drawing.Point(340, 60);
            this.checklbColumn.Name = "checklbColumn";
            this.checklbColumn.Size = new System.Drawing.Size(120, 199);
            this.checklbColumn.TabIndex = 3;
            // 
            // picbImage1
            // 
            this.picbImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbImage1.Location = new System.Drawing.Point(466, 12);
            this.picbImage1.Name = "picbImage1";
            this.picbImage1.Size = new System.Drawing.Size(135, 191);
            this.picbImage1.TabIndex = 4;
            this.picbImage1.TabStop = false;
            this.picbImage1.Click += new System.EventHandler(this.picbImage1_Click);
            // 
            // cbSheetName
            // 
            this.cbSheetName.FormattingEnabled = true;
            this.cbSheetName.Location = new System.Drawing.Point(106, 64);
            this.cbSheetName.Name = "cbSheetName";
            this.cbSheetName.Size = new System.Drawing.Size(212, 21);
            this.cbSheetName.TabIndex = 5;
            this.cbSheetName.SelectedValueChanged += new System.EventHandler(this.cbSheetName_SelectedValueChanged);
            // 
            // grbImageForm
            // 
            this.grbImageForm.Controls.Add(this.radEmpCode);
            this.grbImageForm.Controls.Add(this.radAccountName);
            this.grbImageForm.Location = new System.Drawing.Point(106, 103);
            this.grbImageForm.Name = "grbImageForm";
            this.grbImageForm.Size = new System.Drawing.Size(212, 86);
            this.grbImageForm.TabIndex = 6;
            this.grbImageForm.TabStop = false;
            this.grbImageForm.Text = "Choose Image Form";
            // 
            // radEmpCode
            // 
            this.radEmpCode.AutoSize = true;
            this.radEmpCode.Location = new System.Drawing.Point(20, 54);
            this.radEmpCode.Name = "radEmpCode";
            this.radEmpCode.Size = new System.Drawing.Size(99, 17);
            this.radEmpCode.TabIndex = 0;
            this.radEmpCode.TabStop = true;
            this.radEmpCode.Text = "Employee Code";
            this.radEmpCode.UseVisualStyleBackColor = true;
            this.radEmpCode.CheckedChanged += new System.EventHandler(this.radEmpCode_CheckedChanged);
            // 
            // radAccountName
            // 
            this.radAccountName.AutoSize = true;
            this.radAccountName.Location = new System.Drawing.Point(20, 31);
            this.radAccountName.Name = "radAccountName";
            this.radAccountName.Size = new System.Drawing.Size(96, 17);
            this.radAccountName.TabIndex = 0;
            this.radAccountName.TabStop = true;
            this.radAccountName.Text = "Account Name";
            this.radAccountName.UseVisualStyleBackColor = true;
            this.radAccountName.CheckedChanged += new System.EventHandler(this.radAccountName_CheckedChanged);
            // 
            // grbNumberImage
            // 
            this.grbNumberImage.Controls.Add(this.rad5Image);
            this.grbNumberImage.Controls.Add(this.rad1Image);
            this.grbNumberImage.Location = new System.Drawing.Point(103, 195);
            this.grbNumberImage.Name = "grbNumberImage";
            this.grbNumberImage.Size = new System.Drawing.Size(215, 86);
            this.grbNumberImage.TabIndex = 6;
            this.grbNumberImage.TabStop = false;
            this.grbNumberImage.Text = "Number of Images";
            // 
            // rad5Image
            // 
            this.rad5Image.AutoSize = true;
            this.rad5Image.Location = new System.Drawing.Point(21, 54);
            this.rad5Image.Name = "rad5Image";
            this.rad5Image.Size = new System.Drawing.Size(68, 17);
            this.rad5Image.TabIndex = 0;
            this.rad5Image.TabStop = true;
            this.rad5Image.Text = "5 Images";
            this.rad5Image.UseVisualStyleBackColor = true;
            this.rad5Image.CheckedChanged += new System.EventHandler(this.rad5Image_CheckedChanged);
            // 
            // rad1Image
            // 
            this.rad1Image.AutoSize = true;
            this.rad1Image.Location = new System.Drawing.Point(21, 31);
            this.rad1Image.Name = "rad1Image";
            this.rad1Image.Size = new System.Drawing.Size(66, 17);
            this.rad1Image.TabIndex = 0;
            this.rad1Image.TabStop = true;
            this.rad1Image.Text = "1 Image ";
            this.rad1Image.UseVisualStyleBackColor = true;
            this.rad1Image.CheckedChanged += new System.EventHandler(this.rad1Image_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1159, 265);
            this.dataGridView1.TabIndex = 7;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Full Table",
            "Enough",
            "Lack"});
            this.cbSort.Location = new System.Drawing.Point(106, 360);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(209, 21);
            this.cbSort.TabIndex = 8;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(3, 360);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(26, 13);
            this.lblSort.TabIndex = 0;
            this.lblSort.Text = "Sort";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(340, 360);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(120, 23);
            this.btnExportExcel.TabIndex = 2;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // picbImage2
            // 
            this.picbImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbImage2.Location = new System.Drawing.Point(607, 12);
            this.picbImage2.Name = "picbImage2";
            this.picbImage2.Size = new System.Drawing.Size(135, 191);
            this.picbImage2.TabIndex = 4;
            this.picbImage2.TabStop = false;
            // 
            // picImage3
            // 
            this.picImage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage3.Location = new System.Drawing.Point(748, 12);
            this.picImage3.Name = "picImage3";
            this.picImage3.Size = new System.Drawing.Size(135, 191);
            this.picImage3.TabIndex = 4;
            this.picImage3.TabStop = false;
            this.picImage3.Click += new System.EventHandler(this.picImage3_Click);
            // 
            // picbImage4
            // 
            this.picbImage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbImage4.Location = new System.Drawing.Point(889, 12);
            this.picbImage4.Name = "picbImage4";
            this.picbImage4.Size = new System.Drawing.Size(135, 191);
            this.picbImage4.TabIndex = 4;
            this.picbImage4.TabStop = false;
            // 
            // picbImage5
            // 
            this.picbImage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbImage5.Location = new System.Drawing.Point(1030, 12);
            this.picbImage5.Name = "picbImage5";
            this.picbImage5.Size = new System.Drawing.Size(135, 191);
            this.picbImage5.TabIndex = 4;
            this.picbImage5.TabStop = false;
            // 
            // grbCrop
            // 
            this.grbCrop.Controls.Add(this.radioButton5);
            this.grbCrop.Controls.Add(this.radioButton6);
            this.grbCrop.Location = new System.Drawing.Point(466, 226);
            this.grbCrop.Name = "grbCrop";
            this.grbCrop.Size = new System.Drawing.Size(212, 86);
            this.grbCrop.TabIndex = 6;
            this.grbCrop.TabStop = false;
            this.grbCrop.Text = "groupBox1";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(20, 54);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton1";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(20, 31);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton1";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // grbBase64
            // 
            this.grbBase64.Controls.Add(this.radioButton7);
            this.grbBase64.Controls.Add(this.radioButton8);
            this.grbBase64.Location = new System.Drawing.Point(796, 229);
            this.grbBase64.Name = "grbBase64";
            this.grbBase64.Size = new System.Drawing.Size(212, 86);
            this.grbBase64.TabIndex = 6;
            this.grbBase64.TabStop = false;
            this.grbBase64.Text = "groupBox1";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(20, 54);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(85, 17);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "radioButton1";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(20, 31);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(85, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "radioButton1";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(707, 326);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 9;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(385, 258);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(3, 326);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(81, 13);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "Number Images";
            // 
            // lblImageCount
            // 
            this.lblImageCount.AutoSize = true;
            this.lblImageCount.Location = new System.Drawing.Point(103, 326);
            this.lblImageCount.Name = "lblImageCount";
            this.lblImageCount.Size = new System.Drawing.Size(25, 13);
            this.lblImageCount.TabIndex = 11;
            this.lblImageCount.Text = "000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 676);
            this.Controls.Add(this.lblImageCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbNumberImage);
            this.Controls.Add(this.grbCrop);
            this.Controls.Add(this.grbBase64);
            this.Controls.Add(this.grbImageForm);
            this.Controls.Add(this.cbSheetName);
            this.Controls.Add(this.picbImage5);
            this.Controls.Add(this.picbImage4);
            this.Controls.Add(this.picImage3);
            this.Controls.Add(this.picbImage2);
            this.Controls.Add(this.picbImage1);
            this.Controls.Add(this.checklbColumn);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnFolderImage);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.txtFolderImage);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.txtExcelPath);
            this.Controls.Add(this.lblFolderImage);
            this.Controls.Add(this.lblSheetName);
            this.Controls.Add(this.lblExcelPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbImage1)).EndInit();
            this.grbImageForm.ResumeLayout(false);
            this.grbImageForm.PerformLayout();
            this.grbNumberImage.ResumeLayout(false);
            this.grbNumberImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage5)).EndInit();
            this.grbCrop.ResumeLayout(false);
            this.grbCrop.PerformLayout();
            this.grbBase64.ResumeLayout(false);
            this.grbBase64.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExcelPath;
        private System.Windows.Forms.Label lblSheetName;
        private System.Windows.Forms.Label lblFolderImage;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.TextBox txtFolderImage;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnFolderImage;
        private System.Windows.Forms.CheckedListBox checklbColumn;
        private System.Windows.Forms.PictureBox picbImage1;
        private System.Windows.Forms.ComboBox cbSheetName;
        private System.Windows.Forms.GroupBox grbImageForm;
        private System.Windows.Forms.RadioButton radEmpCode;
        private System.Windows.Forms.RadioButton radAccountName;
        private System.Windows.Forms.GroupBox grbNumberImage;
        private System.Windows.Forms.RadioButton rad5Image;
        private System.Windows.Forms.RadioButton rad1Image;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.PictureBox picbImage2;
        private System.Windows.Forms.PictureBox picImage3;
        private System.Windows.Forms.PictureBox picbImage4;
        private System.Windows.Forms.PictureBox picbImage5;
        private System.Windows.Forms.GroupBox grbCrop;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox grbBase64;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblImageCount;
    }
}

