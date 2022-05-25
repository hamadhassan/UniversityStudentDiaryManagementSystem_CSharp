﻿namespace UniversityStudentDiaryManagementSystem
{
    partial class frmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxAuthor = new System.Windows.Forms.TextBox();
            this.lblBookFrom = new System.Windows.Forms.Label();
            this.txtbxBookFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rctxtbxRemaks = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.rctxtbxRemaks);
            this.groupBox1.Controls.Add(this.txtbxBookFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtbxAuthor);
            this.groupBox1.Controls.Add(this.lblBookFrom);
            this.groupBox1.Controls.Add(this.txtbxTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbcType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type :";
            // 
            // cmbcType
            // 
            this.cmbcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbcType.Items.AddRange(new object[] {
            "Select option",
            "Borrow",
            "Purchase"});
            this.cmbcType.Location = new System.Drawing.Point(116, 31);
            this.cmbcType.Name = "cmbcType";
            this.cmbcType.Size = new System.Drawing.Size(179, 28);
            this.cmbcType.TabIndex = 1;
            this.cmbcType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title :";
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Location = new System.Drawing.Point(116, 62);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(179, 26);
            this.txtbxTitle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author :";
            // 
            // txtbxAuthor
            // 
            this.txtbxAuthor.Location = new System.Drawing.Point(116, 91);
            this.txtbxAuthor.Name = "txtbxAuthor";
            this.txtbxAuthor.Size = new System.Drawing.Size(179, 26);
            this.txtbxAuthor.TabIndex = 2;
            // 
            // lblBookFrom
            // 
            this.lblBookFrom.AutoSize = true;
            this.lblBookFrom.Location = new System.Drawing.Point(6, 123);
            this.lblBookFrom.Name = "lblBookFrom";
            this.lblBookFrom.Size = new System.Drawing.Size(108, 20);
            this.lblBookFrom.TabIndex = 0;
            this.lblBookFrom.Text = "Friend Name :";
            // 
            // txtbxBookFrom
            // 
            this.txtbxBookFrom.Location = new System.Drawing.Point(116, 121);
            this.txtbxBookFrom.Name = "txtbxBookFrom";
            this.txtbxBookFrom.Size = new System.Drawing.Size(179, 26);
            this.txtbxBookFrom.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Remarks :";
            // 
            // rctxtbxRemaks
            // 
            this.rctxtbxRemaks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rctxtbxRemaks.Location = new System.Drawing.Point(116, 150);
            this.rctxtbxRemaks.Name = "rctxtbxRemaks";
            this.rctxtbxRemaks.Size = new System.Drawing.Size(179, 53);
            this.rctxtbxRemaks.TabIndex = 3;
            this.rctxtbxRemaks.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(116, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 31);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(210, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 31);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 268);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rctxtbxRemaks;
        private System.Windows.Forms.TextBox txtbxBookFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxAuthor;
        private System.Windows.Forms.Label lblBookFrom;
        private System.Windows.Forms.TextBox txtbxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbcType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}