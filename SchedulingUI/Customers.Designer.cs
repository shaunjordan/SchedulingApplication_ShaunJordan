namespace SchedulingUI
{
    partial class Customers
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
            this.backBtn = new System.Windows.Forms.Button();
            this.delCustBtn = new System.Windows.Forms.Button();
            this.editCustBtn = new System.Windows.Forms.Button();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(343, 391);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(81, 23);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // delCustBtn
            // 
            this.delCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delCustBtn.Location = new System.Drawing.Point(331, 346);
            this.delCustBtn.Name = "delCustBtn";
            this.delCustBtn.Size = new System.Drawing.Size(98, 23);
            this.delCustBtn.TabIndex = 8;
            this.delCustBtn.Text = "Delete Customer";
            this.delCustBtn.UseVisualStyleBackColor = true;
            // 
            // editCustBtn
            // 
            this.editCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCustBtn.Location = new System.Drawing.Point(196, 346);
            this.editCustBtn.Name = "editCustBtn";
            this.editCustBtn.Size = new System.Drawing.Size(129, 23);
            this.editCustBtn.TabIndex = 7;
            this.editCustBtn.Text = "Edit Selected Customer";
            this.editCustBtn.UseVisualStyleBackColor = true;
            // 
            // addCustBtn
            // 
            this.addCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustBtn.Location = new System.Drawing.Point(78, 346);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(112, 23);
            this.addCustBtn.TabIndex = 6;
            this.addCustBtn.Text = "Add New Customer";
            this.addCustBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 294);
            this.dataGridView1.TabIndex = 10;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.delCustBtn);
            this.Controls.Add(this.editCustBtn);
            this.Controls.Add(this.addCustBtn);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button delCustBtn;
        private System.Windows.Forms.Button editCustBtn;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}