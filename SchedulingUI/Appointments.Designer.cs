namespace SchedulingUI
{
    partial class Appointments
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
            this.addApptBtn = new System.Windows.Forms.Button();
            this.editApptBtn = new System.Windows.Forms.Button();
            this.delApptBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.apptsTabs = new System.Windows.Forms.TabControl();
            this.apptsByMonthTab = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.apptsByWeekTab = new System.Windows.Forms.TabPage();
            this.apptsTabs.SuspendLayout();
            this.apptsByMonthTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // addApptBtn
            // 
            this.addApptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addApptBtn.Location = new System.Drawing.Point(264, 351);
            this.addApptBtn.Name = "addApptBtn";
            this.addApptBtn.Size = new System.Drawing.Size(81, 23);
            this.addApptBtn.TabIndex = 2;
            this.addApptBtn.Text = "Add Appointment";
            this.addApptBtn.UseVisualStyleBackColor = true;
            this.addApptBtn.Click += new System.EventHandler(this.addApptBtn_Click);
            // 
            // editApptBtn
            // 
            this.editApptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editApptBtn.Location = new System.Drawing.Point(360, 351);
            this.editApptBtn.Name = "editApptBtn";
            this.editApptBtn.Size = new System.Drawing.Size(81, 23);
            this.editApptBtn.TabIndex = 3;
            this.editApptBtn.Text = "Edit Appointment";
            this.editApptBtn.UseVisualStyleBackColor = true;
            // 
            // delApptBtn
            // 
            this.delApptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delApptBtn.Location = new System.Drawing.Point(459, 351);
            this.delApptBtn.Name = "delApptBtn";
            this.delApptBtn.Size = new System.Drawing.Size(81, 23);
            this.delApptBtn.TabIndex = 4;
            this.delApptBtn.Text = "Delete Appointment";
            this.delApptBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(459, 403);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(81, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // apptsTabs
            // 
            this.apptsTabs.Controls.Add(this.apptsByMonthTab);
            this.apptsTabs.Controls.Add(this.apptsByWeekTab);
            this.apptsTabs.Location = new System.Drawing.Point(34, 23);
            this.apptsTabs.Name = "apptsTabs";
            this.apptsTabs.SelectedIndex = 0;
            this.apptsTabs.Size = new System.Drawing.Size(702, 322);
            this.apptsTabs.TabIndex = 6;
            // 
            // apptsByMonthTab
            // 
            this.apptsByMonthTab.Controls.Add(this.monthCalendar1);
            this.apptsByMonthTab.Location = new System.Drawing.Point(4, 22);
            this.apptsByMonthTab.Name = "apptsByMonthTab";
            this.apptsByMonthTab.Padding = new System.Windows.Forms.Padding(3);
            this.apptsByMonthTab.Size = new System.Drawing.Size(694, 296);
            this.apptsByMonthTab.TabIndex = 0;
            this.apptsByMonthTab.Text = "Appointments - Monthly";
            this.apptsByMonthTab.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(226, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // apptsByWeekTab
            // 
            this.apptsByWeekTab.Location = new System.Drawing.Point(4, 22);
            this.apptsByWeekTab.Name = "apptsByWeekTab";
            this.apptsByWeekTab.Padding = new System.Windows.Forms.Padding(3);
            this.apptsByWeekTab.Size = new System.Drawing.Size(694, 296);
            this.apptsByWeekTab.TabIndex = 1;
            this.apptsByWeekTab.Text = "Appointments - Weekly";
            this.apptsByWeekTab.UseVisualStyleBackColor = true;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.apptsTabs);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.delApptBtn);
            this.Controls.Add(this.editApptBtn);
            this.Controls.Add(this.addApptBtn);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.apptsTabs.ResumeLayout(false);
            this.apptsByMonthTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addApptBtn;
        private System.Windows.Forms.Button editApptBtn;
        private System.Windows.Forms.Button delApptBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TabControl apptsTabs;
        private System.Windows.Forms.TabPage apptsByMonthTab;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage apptsByWeekTab;
    }
}