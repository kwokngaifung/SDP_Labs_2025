namespace SDP_Labs_2025.Lab4
{
    partial class frmLab4
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
            lblResult = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblResult.Location = new System.Drawing.Point(195, 179);
            lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(458, 167);
            lblResult.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(195, 106);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(181, 47);
            button1.TabIndex = 1;
            button1.Text = "Http Get";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmLab4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(button1);
            Controls.Add(lblResult);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmLab4";
            Text = "frmLab4";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
    }
}