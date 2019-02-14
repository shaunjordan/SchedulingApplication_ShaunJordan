namespace SchedulingUI
{
    partial class AddAppointment
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
            this.addApptGroupBox = new System.Windows.Forms.GroupBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.apptCustSelect = new System.Windows.Forms.ComboBox();
            this.apptCustomerLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.apptStartLabel = new System.Windows.Forms.Label();
            this.apptTypeLabel = new System.Windows.Forms.Label();
            this.apptContactLabel = new System.Windows.Forms.Label();
            this.apptLocationLabel = new System.Windows.Forms.Label();
            this.apptDescLabel = new System.Windows.Forms.Label();
            this.apptTitleLabel = new System.Windows.Forms.Label();
            this.apptContactText = new System.Windows.Forms.TextBox();
            this.apptLocationText = new System.Windows.Forms.TextBox();
            this.apptDescText = new System.Windows.Forms.TextBox();
            this.apptTitleText = new System.Windows.Forms.TextBox();
            this.addApptBtn = new System.Windows.Forms.Button();
            this.cancelAddApptBtn = new System.Windows.Forms.Button();
            this.apptTypeText = new System.Windows.Forms.ComboBox();
            this.addApptGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addApptGroupBox
            // 
            this.addApptGroupBox.Controls.Add(this.apptTypeText);
            this.addApptGroupBox.Controls.Add(this.urlText);
            this.addApptGroupBox.Controls.Add(this.urlLabel);
            this.addApptGroupBox.Controls.Add(this.endTimePicker);
            this.addApptGroupBox.Controls.Add(this.apptCustSelect);
            this.addApptGroupBox.Controls.Add(this.apptCustomerLabel);
            this.addApptGroupBox.Controls.Add(this.startTimePicker);
            this.addApptGroupBox.Controls.Add(this.endTimeLabel);
            this.addApptGroupBox.Controls.Add(this.apptStartLabel);
            this.addApptGroupBox.Controls.Add(this.apptTypeLabel);
            this.addApptGroupBox.Controls.Add(this.apptContactLabel);
            this.addApptGroupBox.Controls.Add(this.apptLocationLabel);
            this.addApptGroupBox.Controls.Add(this.apptDescLabel);
            this.addApptGroupBox.Controls.Add(this.apptTitleLabel);
            this.addApptGroupBox.Controls.Add(this.apptContactText);
            this.addApptGroupBox.Controls.Add(this.apptLocationText);
            this.addApptGroupBox.Controls.Add(this.apptDescText);
            this.addApptGroupBox.Controls.Add(this.apptTitleText);
            this.addApptGroupBox.Location = new System.Drawing.Point(37, 28);
            this.addApptGroupBox.Name = "addApptGroupBox";
            this.addApptGroupBox.Size = new System.Drawing.Size(427, 381);
            this.addApptGroupBox.TabIndex = 0;
            this.addApptGroupBox.TabStop = false;
            this.addApptGroupBox.Text = "Add Appointment";
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(191, 238);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(217, 20);
            this.urlText.TabIndex = 17;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(7, 245);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 16;
            this.urlLabel.Text = "URL";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(212, 334);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(196, 20);
            this.endTimePicker.TabIndex = 15;
            this.endTimePicker.Value = new System.DateTime(2019, 1, 6, 16, 0, 35, 0);
            // 
            // apptCustSelect
            // 
            this.apptCustSelect.FormattingEnabled = true;
            this.apptCustSelect.Location = new System.Drawing.Point(191, 59);
            this.apptCustSelect.Name = "apptCustSelect";
            this.apptCustSelect.Size = new System.Drawing.Size(217, 21);
            this.apptCustSelect.TabIndex = 14;
            // 
            // apptCustomerLabel
            // 
            this.apptCustomerLabel.AutoSize = true;
            this.apptCustomerLabel.Location = new System.Drawing.Point(7, 68);
            this.apptCustomerLabel.Name = "apptCustomerLabel";
            this.apptCustomerLabel.Size = new System.Drawing.Size(51, 13);
            this.apptCustomerLabel.TabIndex = 13;
            this.apptCustomerLabel.Text = "Customer";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(212, 292);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(196, 20);
            this.startTimePicker.TabIndex = 12;
            this.startTimePicker.Value = new System.DateTime(2019, 1, 6, 16, 0, 35, 0);
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(7, 341);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.endTimeLabel.TabIndex = 11;
            this.endTimeLabel.Text = "End Time";
            // 
            // apptStartLabel
            // 
            this.apptStartLabel.AutoSize = true;
            this.apptStartLabel.Location = new System.Drawing.Point(7, 299);
            this.apptStartLabel.Name = "apptStartLabel";
            this.apptStartLabel.Size = new System.Drawing.Size(55, 13);
            this.apptStartLabel.TabIndex = 10;
            this.apptStartLabel.Text = "Start Time";
            // 
            // apptTypeLabel
            // 
            this.apptTypeLabel.AutoSize = true;
            this.apptTypeLabel.Location = new System.Drawing.Point(7, 212);
            this.apptTypeLabel.Name = "apptTypeLabel";
            this.apptTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.apptTypeLabel.TabIndex = 9;
            this.apptTypeLabel.Text = "Appointment Type";
            // 
            // apptContactLabel
            // 
            this.apptContactLabel.AutoSize = true;
            this.apptContactLabel.Location = new System.Drawing.Point(7, 174);
            this.apptContactLabel.Name = "apptContactLabel";
            this.apptContactLabel.Size = new System.Drawing.Size(106, 13);
            this.apptContactLabel.TabIndex = 8;
            this.apptContactLabel.Text = "Appointment Contact";
            // 
            // apptLocationLabel
            // 
            this.apptLocationLabel.AutoSize = true;
            this.apptLocationLabel.Location = new System.Drawing.Point(7, 137);
            this.apptLocationLabel.Name = "apptLocationLabel";
            this.apptLocationLabel.Size = new System.Drawing.Size(110, 13);
            this.apptLocationLabel.TabIndex = 7;
            this.apptLocationLabel.Text = "Appointment Location";
            // 
            // apptDescLabel
            // 
            this.apptDescLabel.AutoSize = true;
            this.apptDescLabel.Location = new System.Drawing.Point(7, 98);
            this.apptDescLabel.Name = "apptDescLabel";
            this.apptDescLabel.Size = new System.Drawing.Size(122, 13);
            this.apptDescLabel.TabIndex = 6;
            this.apptDescLabel.Text = "Appointment Description";
            // 
            // apptTitleLabel
            // 
            this.apptTitleLabel.AutoSize = true;
            this.apptTitleLabel.Location = new System.Drawing.Point(7, 32);
            this.apptTitleLabel.Name = "apptTitleLabel";
            this.apptTitleLabel.Size = new System.Drawing.Size(89, 13);
            this.apptTitleLabel.TabIndex = 5;
            this.apptTitleLabel.Text = "Appointment Title";
            // 
            // apptContactText
            // 
            this.apptContactText.Location = new System.Drawing.Point(191, 167);
            this.apptContactText.Name = "apptContactText";
            this.apptContactText.Size = new System.Drawing.Size(217, 20);
            this.apptContactText.TabIndex = 3;
            // 
            // apptLocationText
            // 
            this.apptLocationText.Location = new System.Drawing.Point(191, 130);
            this.apptLocationText.Name = "apptLocationText";
            this.apptLocationText.Size = new System.Drawing.Size(217, 20);
            this.apptLocationText.TabIndex = 2;
            // 
            // apptDescText
            // 
            this.apptDescText.Location = new System.Drawing.Point(191, 91);
            this.apptDescText.Name = "apptDescText";
            this.apptDescText.Size = new System.Drawing.Size(217, 20);
            this.apptDescText.TabIndex = 1;
            // 
            // apptTitleText
            // 
            this.apptTitleText.Location = new System.Drawing.Point(191, 29);
            this.apptTitleText.Name = "apptTitleText";
            this.apptTitleText.Size = new System.Drawing.Size(217, 20);
            this.apptTitleText.TabIndex = 0;
            // 
            // addApptBtn
            // 
            this.addApptBtn.Location = new System.Drawing.Point(249, 415);
            this.addApptBtn.Name = "addApptBtn";
            this.addApptBtn.Size = new System.Drawing.Size(104, 23);
            this.addApptBtn.TabIndex = 1;
            this.addApptBtn.Text = "Add Appointment";
            this.addApptBtn.UseVisualStyleBackColor = true;
            this.addApptBtn.Click += new System.EventHandler(this.addApptBtn_Click);
            // 
            // cancelAddApptBtn
            // 
            this.cancelAddApptBtn.Location = new System.Drawing.Point(370, 415);
            this.cancelAddApptBtn.Name = "cancelAddApptBtn";
            this.cancelAddApptBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelAddApptBtn.TabIndex = 2;
            this.cancelAddApptBtn.Text = "Cancel";
            this.cancelAddApptBtn.UseVisualStyleBackColor = true;
            this.cancelAddApptBtn.Click += new System.EventHandler(this.cancelAddApptBtn_Click);
            // 
            // apptTypeText
            // 
            this.apptTypeText.FormattingEnabled = true;
            this.apptTypeText.Location = new System.Drawing.Point(191, 203);
            this.apptTypeText.Name = "apptTypeText";
            this.apptTypeText.Size = new System.Drawing.Size(217, 21);
            this.apptTypeText.TabIndex = 18;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.cancelAddApptBtn);
            this.Controls.Add(this.addApptBtn);
            this.Controls.Add(this.addApptGroupBox);
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.addApptGroupBox.ResumeLayout(false);
            this.addApptGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addApptGroupBox;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label apptStartLabel;
        private System.Windows.Forms.Label apptTypeLabel;
        private System.Windows.Forms.Label apptContactLabel;
        private System.Windows.Forms.Label apptLocationLabel;
        private System.Windows.Forms.Label apptDescLabel;
        private System.Windows.Forms.Label apptTitleLabel;
        private System.Windows.Forms.TextBox apptContactText;
        private System.Windows.Forms.TextBox apptLocationText;
        private System.Windows.Forms.TextBox apptDescText;
        private System.Windows.Forms.TextBox apptTitleText;
        private System.Windows.Forms.ComboBox apptCustSelect;
        private System.Windows.Forms.Label apptCustomerLabel;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Button addApptBtn;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button cancelAddApptBtn;
        private System.Windows.Forms.ComboBox apptTypeText;
    }
}