using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SDP_Labs_2025.Lab1
{
    public partial class frmLab1 : Form
    {
        public frmLab1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
                txtNum3.Text = Convert.ToString(x);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Please input number in the input field.");
            }
        }
    }
}
