namespace SDP_Labs_2025.Lab5
{
    partial class frmLab5
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
            lblCustomerDetails = new System.Windows.Forms.Label();
            dgvCustomerDetails = new System.Windows.Forms.DataGridView();
            lblCustomerName = new System.Windows.Forms.Label();
            txtCustomerName = new System.Windows.Forms.TextBox();
            butSearch = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetails).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerDetails
            // 
            lblCustomerDetails.AutoSize = true;
            lblCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCustomerDetails.Location = new System.Drawing.Point(57, 21);
            lblCustomerDetails.Name = "lblCustomerDetails";
            lblCustomerDetails.Size = new System.Drawing.Size(155, 25);
            lblCustomerDetails.TabIndex = 0;
            lblCustomerDetails.Text = "Customer Details";
            // 
            // dgvCustomerDetails
            // 
            dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerDetails.Location = new System.Drawing.Point(57, 134);
            dgvCustomerDetails.Name = "dgvCustomerDetails";
            dgvCustomerDetails.Size = new System.Drawing.Size(597, 282);
            dgvCustomerDetails.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new System.Drawing.Point(57, 84);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new System.Drawing.Size(97, 15);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(172, 81);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(150, 23);
            txtCustomerName.TabIndex = 3;
            // 
            // butSearch
            // 
            butSearch.Location = new System.Drawing.Point(360, 80);
            butSearch.Name = "butSearch";
            butSearch.Size = new System.Drawing.Size(75, 23);
            butSearch.TabIndex = 4;
            butSearch.Text = "Search";
            butSearch.UseVisualStyleBackColor = true;
            butSearch.Click += butSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(698, 393);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmLab5
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(butSearch);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Controls.Add(dgvCustomerDetails);
            Controls.Add(lblCustomerDetails);
            Name = "frmLab5";
            Text = "frmLab5";
            Load += frmLab5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.DataGridView dgvCustomerDetails;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button btnUpdate;
    }
}