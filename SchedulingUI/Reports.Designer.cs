namespace SchedulingUI
{
    partial class Reports
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
            this.typesByMonthBtn = new System.Windows.Forms.Button();
            this.schedBtn = new System.Windows.Forms.Button();
            this.totalCustsBtn = new System.Windows.Forms.Button();
            this.reportsGroupBox = new System.Windows.Forms.GroupBox();
            this.exitReportsBtn = new System.Windows.Forms.Button();
            this.reportsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // typesByMonthBtn
            // 
            this.typesByMonthBtn.Location = new System.Drawing.Point(19, 39);
            this.typesByMonthBtn.Name = "typesByMonthBtn";
            this.typesByMonthBtn.Size = new System.Drawing.Size(166, 23);
            this.typesByMonthBtn.TabIndex = 0;
            this.typesByMonthBtn.Text = "Appointment Types by Month";
            this.typesByMonthBtn.UseVisualStyleBackColor = true;
            this.typesByMonthBtn.Click += new System.EventHandler(this.typesByMonthBtn_Click);
            // 
            // schedBtn
            // 
            this.schedBtn.Location = new System.Drawing.Point(19, 83);
            this.schedBtn.Name = "schedBtn";
            this.schedBtn.Size = new System.Drawing.Size(166, 23);
            this.schedBtn.TabIndex = 1;
            this.schedBtn.Text = "Consultant Schedules";
            this.schedBtn.UseVisualStyleBackColor = true;
            this.schedBtn.Click += new System.EventHandler(this.schedBtn_Click);
            // 
            // totalCustsBtn
            // 
            this.totalCustsBtn.Location = new System.Drawing.Point(19, 126);
            this.totalCustsBtn.Name = "totalCustsBtn";
            this.totalCustsBtn.Size = new System.Drawing.Size(166, 23);
            this.totalCustsBtn.TabIndex = 2;
            this.totalCustsBtn.Text = "Customers By Country";
            this.totalCustsBtn.UseVisualStyleBackColor = true;
            this.totalCustsBtn.Click += new System.EventHandler(this.totalCustsBtn_Click);
            // 
            // reportsGroupBox
            // 
            this.reportsGroupBox.Controls.Add(this.schedBtn);
            this.reportsGroupBox.Controls.Add(this.totalCustsBtn);
            this.reportsGroupBox.Controls.Add(this.typesByMonthBtn);
            this.reportsGroupBox.Location = new System.Drawing.Point(12, 30);
            this.reportsGroupBox.Name = "reportsGroupBox";
            this.reportsGroupBox.Size = new System.Drawing.Size(208, 172);
            this.reportsGroupBox.TabIndex = 3;
            this.reportsGroupBox.TabStop = false;
            this.reportsGroupBox.Text = "Output a report";
            // 
            // exitReportsBtn
            // 
            this.exitReportsBtn.Location = new System.Drawing.Point(68, 261);
            this.exitReportsBtn.Name = "exitReportsBtn";
            this.exitReportsBtn.Size = new System.Drawing.Size(89, 27);
            this.exitReportsBtn.TabIndex = 4;
            this.exitReportsBtn.Text = "Back";
            this.exitReportsBtn.UseVisualStyleBackColor = true;
            this.exitReportsBtn.Click += new System.EventHandler(this.exitReportsBtn_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 300);
            this.Controls.Add(this.exitReportsBtn);
            this.Controls.Add(this.reportsGroupBox);
            this.Name = "Reports";
            this.Text = "Reports";
            this.reportsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button typesByMonthBtn;
        private System.Windows.Forms.Button schedBtn;
        private System.Windows.Forms.Button totalCustsBtn;
        private System.Windows.Forms.GroupBox reportsGroupBox;
        private System.Windows.Forms.Button exitReportsBtn;
    }
}