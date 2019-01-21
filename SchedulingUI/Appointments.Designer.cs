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
            this.selectMonthLabel = new System.Windows.Forms.Label();
            this.appointmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.monthPicker = new System.Windows.Forms.ComboBox();
            this.apptsByWeekTab = new System.Windows.Forms.TabPage();
            this.weekPicker = new System.Windows.Forms.ComboBox();
            this.apptsTabs.SuspendLayout();
            this.apptsByMonthTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).BeginInit();
            this.apptsByWeekTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // addApptBtn
            // 
            this.addApptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addApptBtn.Location = new System.Drawing.Point(418, 351);
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
            this.editApptBtn.Location = new System.Drawing.Point(518, 351);
            this.editApptBtn.Name = "editApptBtn";
            this.editApptBtn.Size = new System.Drawing.Size(81, 23);
            this.editApptBtn.TabIndex = 3;
            this.editApptBtn.Text = "Edit Appointment";
            this.editApptBtn.UseVisualStyleBackColor = true;
            // 
            // delApptBtn
            // 
            this.delApptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delApptBtn.Location = new System.Drawing.Point(617, 351);
            this.delApptBtn.Name = "delApptBtn";
            this.delApptBtn.Size = new System.Drawing.Size(81, 23);
            this.delApptBtn.TabIndex = 4;
            this.delApptBtn.Text = "Delete Appointment";
            this.delApptBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(518, 415);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(81, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // apptsTabs
            // 
            this.apptsTabs.Controls.Add(this.apptsByMonthTab);
            this.apptsTabs.Controls.Add(this.apptsByWeekTab);
            this.apptsTabs.Location = new System.Drawing.Point(12, 23);
            this.apptsTabs.Name = "apptsTabs";
            this.apptsTabs.SelectedIndex = 0;
            this.apptsTabs.Size = new System.Drawing.Size(1074, 322);
            this.apptsTabs.TabIndex = 6;
            // 
            // apptsByMonthTab
            // 
            this.apptsByMonthTab.Controls.Add(this.selectMonthLabel);
            this.apptsByMonthTab.Controls.Add(this.appointmentsDataGrid);
            this.apptsByMonthTab.Controls.Add(this.monthPicker);
            this.apptsByMonthTab.Location = new System.Drawing.Point(4, 22);
            this.apptsByMonthTab.Name = "apptsByMonthTab";
            this.apptsByMonthTab.Padding = new System.Windows.Forms.Padding(3);
            this.apptsByMonthTab.Size = new System.Drawing.Size(1066, 296);
            this.apptsByMonthTab.TabIndex = 0;
            this.apptsByMonthTab.Text = "Appointments - Monthly";
            this.apptsByMonthTab.UseVisualStyleBackColor = true;
            // 
            // selectMonthLabel
            // 
            this.selectMonthLabel.AutoSize = true;
            this.selectMonthLabel.Location = new System.Drawing.Point(6, 18);
            this.selectMonthLabel.Name = "selectMonthLabel";
            this.selectMonthLabel.Size = new System.Drawing.Size(70, 13);
            this.selectMonthLabel.TabIndex = 12;
            this.selectMonthLabel.Text = "Select Month";
            // 
            // appointmentsDataGrid
            // 
            this.appointmentsDataGrid.AllowUserToAddRows = false;
            this.appointmentsDataGrid.AllowUserToDeleteRows = false;
            this.appointmentsDataGrid.AllowUserToResizeColumns = false;
            this.appointmentsDataGrid.AllowUserToResizeRows = false;
            this.appointmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGrid.Location = new System.Drawing.Point(6, 42);
            this.appointmentsDataGrid.MultiSelect = false;
            this.appointmentsDataGrid.Name = "appointmentsDataGrid";
            this.appointmentsDataGrid.ReadOnly = true;
            this.appointmentsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsDataGrid.ShowEditingIcon = false;
            this.appointmentsDataGrid.Size = new System.Drawing.Size(1054, 248);
            this.appointmentsDataGrid.TabIndex = 11;
            // 
            // monthPicker
            // 
            this.monthPicker.FormattingEnabled = true;
            this.monthPicker.Location = new System.Drawing.Point(88, 15);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new System.Drawing.Size(88, 21);
            this.monthPicker.TabIndex = 0;
            this.monthPicker.SelectedIndexChanged += new System.EventHandler(this.monthPicker_SelectedIndexChanged);
            // 
            // apptsByWeekTab
            // 
            this.apptsByWeekTab.Controls.Add(this.weekPicker);
            this.apptsByWeekTab.Location = new System.Drawing.Point(4, 22);
            this.apptsByWeekTab.Name = "apptsByWeekTab";
            this.apptsByWeekTab.Padding = new System.Windows.Forms.Padding(3);
            this.apptsByWeekTab.Size = new System.Drawing.Size(1066, 296);
            this.apptsByWeekTab.TabIndex = 1;
            this.apptsByWeekTab.Text = "Appointments - Weekly";
            this.apptsByWeekTab.UseVisualStyleBackColor = true;
            // 
            // weekPicker
            // 
            this.weekPicker.FormattingEnabled = true;
            this.weekPicker.Location = new System.Drawing.Point(114, 18);
            this.weekPicker.Name = "weekPicker";
            this.weekPicker.Size = new System.Drawing.Size(315, 21);
            this.weekPicker.TabIndex = 0;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.apptsTabs);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.delApptBtn);
            this.Controls.Add(this.editApptBtn);
            this.Controls.Add(this.addApptBtn);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.apptsTabs.ResumeLayout(false);
            this.apptsByMonthTab.ResumeLayout(false);
            this.apptsByMonthTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGrid)).EndInit();
            this.apptsByWeekTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addApptBtn;
        private System.Windows.Forms.Button editApptBtn;
        private System.Windows.Forms.Button delApptBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TabControl apptsTabs;
        private System.Windows.Forms.TabPage apptsByMonthTab;
        private System.Windows.Forms.TabPage apptsByWeekTab;
        private System.Windows.Forms.ComboBox monthPicker;
        private System.Windows.Forms.DataGridView appointmentsDataGrid;
        private System.Windows.Forms.Label selectMonthLabel;
        private System.Windows.Forms.ComboBox weekPicker;
    }
}