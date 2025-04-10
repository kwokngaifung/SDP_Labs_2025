namespace SDP_Labs_2025.Lab6
{
    partial class frmRegister
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
            btn_submit = new System.Windows.Forms.Button();
            btn_cancel = new System.Windows.Forms.Button();
            lbl_username = new System.Windows.Forms.Label();
            txtbox_username = new System.Windows.Forms.TextBox();
            txtbox_password = new System.Windows.Forms.TextBox();
            lbl_password = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btn_submit
            // 
            btn_submit.Location = new System.Drawing.Point(193, 244);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new System.Drawing.Size(75, 23);
            btn_submit.TabIndex = 0;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btnSubmit_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new System.Drawing.Point(322, 244);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new System.Drawing.Size(75, 23);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btnCancel_Click;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new System.Drawing.Point(193, 75);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new System.Drawing.Size(60, 15);
            lbl_username.TabIndex = 2;
            lbl_username.Text = "Username";
            // 
            // txtbox_username
            // 
            txtbox_username.Location = new System.Drawing.Point(297, 72);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new System.Drawing.Size(100, 23);
            txtbox_username.TabIndex = 3;
            // 
            // txtbox_password
            // 
            txtbox_password.Location = new System.Drawing.Point(297, 143);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.Size = new System.Drawing.Size(100, 23);
            txtbox_password.TabIndex = 5;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new System.Drawing.Point(193, 146);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new System.Drawing.Size(57, 15);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Password";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(590, 395);
            Controls.Add(txtbox_password);
            Controls.Add(lbl_password);
            Controls.Add(txtbox_username);
            Controls.Add(lbl_username);
            Controls.Add(btn_cancel);
            Controls.Add(btn_submit);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_password;
    }
}