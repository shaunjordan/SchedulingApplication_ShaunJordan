﻿namespace SchedulingUI
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.apptMgrBtn = new System.Windows.Forms.Button();
            this.custMgrBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "dbtest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // apptMgrBtn
            // 
            this.apptMgrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apptMgrBtn.Location = new System.Drawing.Point(52, 231);
            this.apptMgrBtn.Name = "apptMgrBtn";
            this.apptMgrBtn.Size = new System.Drawing.Size(130, 23);
            this.apptMgrBtn.TabIndex = 1;
            this.apptMgrBtn.Text = "Manage Appointments";
            this.apptMgrBtn.UseVisualStyleBackColor = true;
            // 
            // custMgrBtn
            // 
            this.custMgrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custMgrBtn.Location = new System.Drawing.Point(208, 231);
            this.custMgrBtn.Name = "custMgrBtn";
            this.custMgrBtn.Size = new System.Drawing.Size(130, 23);
            this.custMgrBtn.TabIndex = 2;
            this.custMgrBtn.Text = "Manage Customers";
            this.custMgrBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(263, 388);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.custMgrBtn);
            this.Controls.Add(this.apptMgrBtn);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button apptMgrBtn;
        private System.Windows.Forms.Button custMgrBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}