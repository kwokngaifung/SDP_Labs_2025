namespace SDP_Labs_2025.Lab2
{
    partial class frmLab2A
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
            this.RedWinde = new System.Windows.Forms.RadioButton();
            this.WhiteWinde = new System.Windows.Forms.RadioButton();
            this.Beer = new System.Windows.Forms.RadioButton();
            this.VISA = new System.Windows.Forms.RadioButton();
            this.MasterCard = new System.Windows.Forms.RadioButton();
            this.WineList = new System.Windows.Forms.GroupBox();
            this.PaymentMethod = new System.Windows.Forms.GroupBox();
            this.Qty = new System.Windows.Forms.Label();
            this.input_Qty = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.WineList.SuspendLayout();
            this.PaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // RedWinde
            // 
            this.RedWinde.AutoSize = true;
            this.RedWinde.Location = new System.Drawing.Point(6, 19);
            this.RedWinde.Name = "RedWinde";
            this.RedWinde.Size = new System.Drawing.Size(109, 17);
            this.RedWinde.TabIndex = 0;
            this.RedWinde.TabStop = true;
            this.RedWinde.Text = "Red Winde($250)";
            this.RedWinde.UseVisualStyleBackColor = true;
            this.RedWinde.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // WhiteWinde
            // 
            this.WhiteWinde.AutoSize = true;
            this.WhiteWinde.Location = new System.Drawing.Point(6, 42);
            this.WhiteWinde.Name = "WhiteWinde";
            this.WhiteWinde.Size = new System.Drawing.Size(117, 17);
            this.WhiteWinde.TabIndex = 1;
            this.WhiteWinde.TabStop = true;
            this.WhiteWinde.Text = "White Winde($180)";
            this.WhiteWinde.UseVisualStyleBackColor = true;
            this.WhiteWinde.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Beer
            // 
            this.Beer.AutoSize = true;
            this.Beer.Location = new System.Drawing.Point(6, 65);
            this.Beer.Name = "Beer";
            this.Beer.Size = new System.Drawing.Size(121, 17);
            this.Beer.TabIndex = 2;
            this.Beer.TabStop = true;
            this.Beer.Text = "Beer (1 dozen) ($75)";
            this.Beer.UseVisualStyleBackColor = true;
            this.Beer.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // VISA
            // 
            this.VISA.AutoSize = true;
            this.VISA.Location = new System.Drawing.Point(6, 19);
            this.VISA.Name = "VISA";
            this.VISA.Size = new System.Drawing.Size(49, 17);
            this.VISA.TabIndex = 3;
            this.VISA.TabStop = true;
            this.VISA.Text = "VISA";
            this.VISA.UseVisualStyleBackColor = true;
            this.VISA.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // MasterCard
            // 
            this.MasterCard.AutoSize = true;
            this.MasterCard.Location = new System.Drawing.Point(6, 42);
            this.MasterCard.Name = "MasterCard";
            this.MasterCard.Size = new System.Drawing.Size(79, 17);
            this.MasterCard.TabIndex = 4;
            this.MasterCard.TabStop = true;
            this.MasterCard.Text = "MasterCard";
            this.MasterCard.UseVisualStyleBackColor = true;
            this.MasterCard.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // WineList
            // 
            this.WineList.Controls.Add(this.RedWinde);
            this.WineList.Controls.Add(this.WhiteWinde);
            this.WineList.Controls.Add(this.Beer);
            this.WineList.Location = new System.Drawing.Point(156, 96);
            this.WineList.Name = "WineList";
            this.WineList.Size = new System.Drawing.Size(200, 100);
            this.WineList.TabIndex = 7;
            this.WineList.TabStop = false;
            this.WineList.Text = "Wine List";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.Controls.Add(this.VISA);
            this.PaymentMethod.Controls.Add(this.MasterCard);
            this.PaymentMethod.Location = new System.Drawing.Point(446, 96);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(200, 100);
            this.PaymentMethod.TabIndex = 8;
            this.PaymentMethod.TabStop = false;
            this.PaymentMethod.Text = "Payment Method";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(449, 239);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(23, 13);
            this.Qty.TabIndex = 9;
            this.Qty.Text = "Qty";
            // 
            // input_Qty
            // 
            this.input_Qty.Location = new System.Drawing.Point(493, 236);
            this.input_Qty.Name = "input_Qty";
            this.input_Qty.Size = new System.Drawing.Size(55, 20);
            this.input_Qty.TabIndex = 10;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(571, 234);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 11;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Location = new System.Drawing.Point(277, 303);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(310, 71);
            this.lblresult.TabIndex = 12;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLab2A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.input_Qty);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.WineList);
            this.Name = "frmLab2A";
            this.Text = "frmLab2A";
            this.WineList.ResumeLayout(false);
            this.WineList.PerformLayout();
            this.PaymentMethod.ResumeLayout(false);
            this.PaymentMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RedWinde;
        private System.Windows.Forms.RadioButton WhiteWinde;
        private System.Windows.Forms.RadioButton Beer;
        private System.Windows.Forms.RadioButton VISA;
        private System.Windows.Forms.RadioButton MasterCard;
        private System.Windows.Forms.GroupBox WineList;
        private System.Windows.Forms.GroupBox PaymentMethod;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.TextBox input_Qty;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label lblresult;
    }
}