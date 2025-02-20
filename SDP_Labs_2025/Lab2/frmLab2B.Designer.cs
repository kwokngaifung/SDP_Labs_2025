namespace SDP_Labs_2025.Lab2
{
    partial class frmLab2B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLab2B));
            this.label1 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSuny = new System.Windows.Forms.RadioButton();
            this.lblSnowy = new System.Windows.Forms.RadioButton();
            this.lblRainy = new System.Windows.Forms.RadioButton();
            this.lblCloudy = new System.Windows.Forms.RadioButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.picCloudy = new System.Windows.Forms.PictureBox();
            this.picSuny = new System.Windows.Forms.PictureBox();
            this.picRainy = new System.Windows.Forms.PictureBox();
            this.picSnowy = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name here :";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(289, 87);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(100, 20);
            this.name_input.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSuny);
            this.groupBox1.Controls.Add(this.lblSnowy);
            this.groupBox1.Controls.Add(this.lblRainy);
            this.groupBox1.Controls.Add(this.lblCloudy);
            this.groupBox1.Location = new System.Drawing.Point(167, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // lblSuny
            // 
            this.lblSuny.AutoSize = true;
            this.lblSuny.Location = new System.Drawing.Point(29, 123);
            this.lblSuny.Name = "lblSuny";
            this.lblSuny.Size = new System.Drawing.Size(55, 17);
            this.lblSuny.TabIndex = 3;
            this.lblSuny.TabStop = true;
            this.lblSuny.Text = "Sunny";
            this.lblSuny.UseVisualStyleBackColor = true;
            this.lblSuny.CheckedChanged += new System.EventHandler(this.lblSuny_CheckedChanged);
            // 
            // lblSnowy
            // 
            this.lblSnowy.AutoSize = true;
            this.lblSnowy.Location = new System.Drawing.Point(29, 85);
            this.lblSnowy.Name = "lblSnowy";
            this.lblSnowy.Size = new System.Drawing.Size(57, 17);
            this.lblSnowy.TabIndex = 2;
            this.lblSnowy.TabStop = true;
            this.lblSnowy.Text = "Snowy";
            this.lblSnowy.UseVisualStyleBackColor = true;
            this.lblSnowy.CheckedChanged += new System.EventHandler(this.lblSnowy_CheckedChanged);
            // 
            // lblRainy
            // 
            this.lblRainy.AutoSize = true;
            this.lblRainy.Location = new System.Drawing.Point(29, 52);
            this.lblRainy.Name = "lblRainy";
            this.lblRainy.Size = new System.Drawing.Size(52, 17);
            this.lblRainy.TabIndex = 1;
            this.lblRainy.TabStop = true;
            this.lblRainy.Text = "Rainy";
            this.lblRainy.UseVisualStyleBackColor = true;
            this.lblRainy.CheckedChanged += new System.EventHandler(this.lblRainy_CheckedChanged);
            // 
            // lblCloudy
            // 
            this.lblCloudy.AutoSize = true;
            this.lblCloudy.Location = new System.Drawing.Point(29, 19);
            this.lblCloudy.Name = "lblCloudy";
            this.lblCloudy.Size = new System.Drawing.Size(57, 17);
            this.lblCloudy.TabIndex = 0;
            this.lblCloudy.TabStop = true;
            this.lblCloudy.Text = "Cloudy";
            this.lblCloudy.UseVisualStyleBackColor = true;
            this.lblCloudy.CheckedChanged += new System.EventHandler(this.lblCloudy_CheckedChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(167, 327);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(442, 47);
            this.lblMessage.TabIndex = 3;
            // 
            // picCloudy
            // 
            this.picCloudy.Image = ((System.Drawing.Image)(resources.GetObject("picCloudy.Image")));
            this.picCloudy.InitialImage = null;
            this.picCloudy.Location = new System.Drawing.Point(475, 139);
            this.picCloudy.Name = "picCloudy";
            this.picCloudy.Size = new System.Drawing.Size(70, 70);
            this.picCloudy.TabIndex = 4;
            this.picCloudy.TabStop = false;
            // 
            // picSuny
            // 
            this.picSuny.Image = ((System.Drawing.Image)(resources.GetObject("picSuny.Image")));
            this.picSuny.Location = new System.Drawing.Point(551, 217);
            this.picSuny.Name = "picSuny";
            this.picSuny.Size = new System.Drawing.Size(70, 70);
            this.picSuny.TabIndex = 5;
            this.picSuny.TabStop = false;
            // 
            // picRainy
            // 
            this.picRainy.Image = ((System.Drawing.Image)(resources.GetObject("picRainy.Image")));
            this.picRainy.Location = new System.Drawing.Point(551, 141);
            this.picRainy.Name = "picRainy";
            this.picRainy.Size = new System.Drawing.Size(70, 70);
            this.picRainy.TabIndex = 6;
            this.picRainy.TabStop = false;
            // 
            // picSnowy
            // 
            this.picSnowy.Image = ((System.Drawing.Image)(resources.GetObject("picSnowy.Image")));
            this.picSnowy.Location = new System.Drawing.Point(475, 215);
            this.picSnowy.Name = "picSnowy";
            this.picSnowy.Size = new System.Drawing.Size(70, 70);
            this.picSnowy.TabIndex = 7;
            this.picSnowy.TabStop = false;
            // 
            // frmLab2B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSnowy);
            this.Controls.Add(this.picRainy);
            this.Controls.Add(this.picSuny);
            this.Controls.Add(this.picCloudy);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label1);
            this.Name = "frmLab2B";
            this.Text = "frmLab2B";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton lblSnowy;
        private System.Windows.Forms.RadioButton lblRainy;
        private System.Windows.Forms.RadioButton lblCloudy;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picCloudy;
        private System.Windows.Forms.PictureBox picSuny;
        private System.Windows.Forms.PictureBox picRainy;
        private System.Windows.Forms.PictureBox picSnowy;
        private System.Windows.Forms.RadioButton lblSuny;
    }
}