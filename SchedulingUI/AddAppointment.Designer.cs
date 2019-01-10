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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addApptGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addApptGroupBox
            // 
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
            this.addApptGroupBox.Controls.Add(this.textBox5);
            this.addApptGroupBox.Controls.Add(this.textBox4);
            this.addApptGroupBox.Controls.Add(this.textBox3);
            this.addApptGroupBox.Controls.Add(this.textBox2);
            this.addApptGroupBox.Controls.Add(this.textBox1);
            this.addApptGroupBox.Location = new System.Drawing.Point(37, 28);
            this.addApptGroupBox.Name = "addApptGroupBox";
            this.addApptGroupBox.Size = new System.Drawing.Size(427, 351);
            this.addApptGroupBox.TabIndex = 0;
            this.addApptGroupBox.TabStop = false;
            this.addApptGroupBox.Text = "Add Appointment";
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
            this.startTimePicker.Location = new System.Drawing.Point(212, 259);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(196, 20);
            this.startTimePicker.TabIndex = 12;
            this.startTimePicker.Value = new System.DateTime(2019, 1, 6, 16, 0, 35, 0);
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(7, 308);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.endTimeLabel.TabIndex = 11;
            this.endTimeLabel.Text = "End Time";
            // 
            // apptStartLabel
            // 
            this.apptStartLabel.AutoSize = true;
            this.apptStartLabel.Location = new System.Drawing.Point(7, 266);
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(191, 205);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(217, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(191, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 0;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(212, 301);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(196, 20);
            this.endTimePicker.TabIndex = 15;
            this.endTimePicker.Value = new System.DateTime(2019, 1, 6, 16, 0, 35, 0);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.addApptGroupBox);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox apptCustSelect;
        private System.Windows.Forms.Label apptCustomerLabel;
        private System.Windows.Forms.DateTimePicker endTimePicker;
    }
}