namespace SchedulingUI
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
            this.testConn = new System.Windows.Forms.Button();
            this.apptMgrBtn = new System.Windows.Forms.Button();
            this.custMgrBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testConn
            // 
            this.testConn.Location = new System.Drawing.Point(409, 386);
            this.testConn.Name = "testConn";
            this.testConn.Size = new System.Drawing.Size(75, 23);
            this.testConn.TabIndex = 0;
            this.testConn.Text = "dbtest";
            this.testConn.UseVisualStyleBackColor = true;
            this.testConn.Click += new System.EventHandler(this.button1_Click);
            // 
            // apptMgrBtn
            // 
            this.apptMgrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apptMgrBtn.Location = new System.Drawing.Point(52, 292);
            this.apptMgrBtn.Name = "apptMgrBtn";
            this.apptMgrBtn.Size = new System.Drawing.Size(130, 23);
            this.apptMgrBtn.TabIndex = 1;
            this.apptMgrBtn.Text = "Manage Appointments";
            this.apptMgrBtn.UseVisualStyleBackColor = true;
            this.apptMgrBtn.Click += new System.EventHandler(this.apptMgrBtn_Click);
            // 
            // custMgrBtn
            // 
            this.custMgrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custMgrBtn.Location = new System.Drawing.Point(203, 292);
            this.custMgrBtn.Name = "custMgrBtn";
            this.custMgrBtn.Size = new System.Drawing.Size(130, 23);
            this.custMgrBtn.TabIndex = 2;
            this.custMgrBtn.Text = "Manage Customers";
            this.custMgrBtn.UseVisualStyleBackColor = true;
            this.custMgrBtn.Click += new System.EventHandler(this.custMgrBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(409, 342);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Location = new System.Drawing.Point(354, 292);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(130, 23);
            this.reportsBtn.TabIndex = 4;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(52, 40);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(35, 13);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.reportsBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.custMgrBtn);
            this.Controls.Add(this.apptMgrBtn);
            this.Controls.Add(this.testConn);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testConn;
        private System.Windows.Forms.Button apptMgrBtn;
        private System.Windows.Forms.Button custMgrBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Label welcomeLabel;
    }
}