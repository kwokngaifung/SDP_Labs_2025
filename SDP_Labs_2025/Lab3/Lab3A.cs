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
    public partial class frmLab3A : Form
    {
        public frmLab3A()
        {
            InitializeComponent();
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show($"You voted for: \n{cboMovie.Text}", "Lab3");
        }
    }
}
