using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Labs_2025.Lab3
{
    public partial class frmLab3B : Form
    {
        public frmLab3B()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double x = 1 + Convert.ToDouble(txtRate.Text);
            Double count = x;
            for (int i = 0; i < 9; i++)
            {
                count = count * x;
            }
            lblValue2.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * count);

            x = 1 + Convert.ToDouble(txtRate.Text);
            count = 0;
            while (Convert.ToDouble(txtAmount.Text) * x < 1000000)
            {
                x = x * (1 + Convert.ToDouble(txtRate.Text));
                count++;
            }
            count++;
            lblMillion2.Text = Convert.ToString(count);
        }
    }
}
