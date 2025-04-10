namespace SDP_Labs_2025.Lab6
{
    partial class frmLab6
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
            btn_Register = new System.Windows.Forms.Button();
            btn_Login = new System.Windows.Forms.Button();
            btn_Logout = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_Register
            // 
            btn_Register.Location = new System.Drawing.Point(212, 70);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new System.Drawing.Size(75, 23);
            btn_Register.TabIndex = 0;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Login
            // 
            btn_Login.Location = new System.Drawing.Point(212, 160);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new System.Drawing.Size(75, 23);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Logout
            // 
            btn_Logout.Enabled = false;
            btn_Logout.Location = new System.Drawing.Point(212, 255);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new System.Drawing.Size(75, 23);
            btn_Logout.TabIndex = 2;
            btn_Logout.Text = "Logout";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // frmLab6
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(499, 348);
            Controls.Add(btn_Logout);
            Controls.Add(btn_Login);
            Controls.Add(btn_Register);
            Name = "frmLab6";
            Text = "frmLab6";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Logout;
    }
}