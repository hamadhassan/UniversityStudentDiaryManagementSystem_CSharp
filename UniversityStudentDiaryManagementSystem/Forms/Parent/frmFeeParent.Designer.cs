﻿namespace UniversityStudentDiaryManagementSystem
{
    partial class frmFeeParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeeParent));
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAcdemicFee = new System.Windows.Forms.GroupBox();
            this.lblNoAcademicFee = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblChallanNo = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarkAsDone = new System.Windows.Forms.Button();
            this.gbxAcdemicFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(599, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Semester :";
            // 
            // gbxAcdemicFee
            // 
            this.gbxAcdemicFee.Controls.Add(this.lblNoAcademicFee);
            this.gbxAcdemicFee.Controls.Add(this.lblRemarks);
            this.gbxAcdemicFee.Controls.Add(this.lblAmount);
            this.gbxAcdemicFee.Controls.Add(this.lblDate);
            this.gbxAcdemicFee.Controls.Add(this.lblChallanNo);
            this.gbxAcdemicFee.Controls.Add(this.lblSemester);
            this.gbxAcdemicFee.Controls.Add(this.label5);
            this.gbxAcdemicFee.Controls.Add(this.label4);
            this.gbxAcdemicFee.Controls.Add(this.label3);
            this.gbxAcdemicFee.Controls.Add(this.label2);
            this.gbxAcdemicFee.Controls.Add(this.label1);
            this.gbxAcdemicFee.Controls.Add(this.btnMarkAsDone);
            this.gbxAcdemicFee.Location = new System.Drawing.Point(12, 12);
            this.gbxAcdemicFee.Name = "gbxAcdemicFee";
            this.gbxAcdemicFee.Size = new System.Drawing.Size(690, 124);
            this.gbxAcdemicFee.TabIndex = 7;
            this.gbxAcdemicFee.TabStop = false;
            this.gbxAcdemicFee.Text = "Academic Fee";
            // 
            // lblNoAcademicFee
            // 
            this.lblNoAcademicFee.AutoSize = true;
            this.lblNoAcademicFee.Location = new System.Drawing.Point(216, 50);
            this.lblNoAcademicFee.Name = "lblNoAcademicFee";
            this.lblNoAcademicFee.Size = new System.Drawing.Size(181, 20);
            this.lblNoAcademicFee.TabIndex = 11;
            this.lblNoAcademicFee.Text = "No Academic Fee is due";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(92, 90);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(24, 20);
            this.lblRemarks.TabIndex = 10;
            this.lblRemarks.Text = "nil";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(92, 61);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(81, 20);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "00000000";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(312, 62);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 20);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "12/12/12";
            // 
            // lblChallanNo
            // 
            this.lblChallanNo.AutoSize = true;
            this.lblChallanNo.Location = new System.Drawing.Point(312, 30);
            this.lblChallanNo.Name = "lblChallanNo";
            this.lblChallanNo.Size = new System.Drawing.Size(85, 20);
            this.lblChallanNo.TabIndex = 10;
            this.lblChallanNo.Text = "2021CS33";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(92, 30);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(34, 20);
            this.lblSemester.TabIndex = 10;
            this.lblSemester.Text = "Fall";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Remarks :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Due Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Challan No :";
            // 
            // btnMarkAsDone
            // 
            this.btnMarkAsDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAsDone.Image = ((System.Drawing.Image)(resources.GetObject("btnMarkAsDone.Image")));
            this.btnMarkAsDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkAsDone.Location = new System.Drawing.Point(521, 45);
            this.btnMarkAsDone.Name = "btnMarkAsDone";
            this.btnMarkAsDone.Size = new System.Drawing.Size(151, 31);
            this.btnMarkAsDone.TabIndex = 5;
            this.btnMarkAsDone.Text = "Mark As Done";
            this.btnMarkAsDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarkAsDone.UseVisualStyleBackColor = true;
            this.btnMarkAsDone.Click += new System.EventHandler(this.btnMarkAsDone_Click);
            // 
            // frmFeeParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 376);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxAcdemicFee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFeeParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fee";
            this.Load += new System.EventHandler(this.frmFeeParent_Load);
            this.gbxAcdemicFee.ResumeLayout(false);
            this.gbxAcdemicFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxAcdemicFee;
        private System.Windows.Forms.Button btnMarkAsDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblChallanNo;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNoAcademicFee;
    }
}