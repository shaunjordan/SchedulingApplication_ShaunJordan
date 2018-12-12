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
            this.SuspendLayout();
            // 
            // addApptBtn
            // 
            this.addApptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addApptBtn.Location = new System.Drawing.Point(67, 321);
            this.addApptBtn.Name = "addApptBtn";
            this.addApptBtn.Size = new System.Drawing.Size(81, 23);
            this.addApptBtn.TabIndex = 2;
            this.addApptBtn.Text = "Add Appointment";
            this.addApptBtn.UseVisualStyleBackColor = true;
            // 
            // editApptBtn
            // 
            this.editApptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editApptBtn.Location = new System.Drawing.Point(163, 321);
            this.editApptBtn.Name = "editApptBtn";
            this.editApptBtn.Size = new System.Drawing.Size(81, 23);
            this.editApptBtn.TabIndex = 3;
            this.editApptBtn.Text = "Edit Appointment";
            this.editApptBtn.UseVisualStyleBackColor = true;
            // 
            // delApptBtn
            // 
            this.delApptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delApptBtn.Location = new System.Drawing.Point(262, 321);
            this.delApptBtn.Name = "delApptBtn";
            this.delApptBtn.Size = new System.Drawing.Size(81, 23);
            this.delApptBtn.TabIndex = 4;
            this.delApptBtn.Text = "Delete Appointment";
            this.delApptBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(262, 373);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(81, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.delApptBtn);
            this.Controls.Add(this.editApptBtn);
            this.Controls.Add(this.addApptBtn);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addApptBtn;
        private System.Windows.Forms.Button editApptBtn;
        private System.Windows.Forms.Button delApptBtn;
        private System.Windows.Forms.Button backBtn;
    }
}