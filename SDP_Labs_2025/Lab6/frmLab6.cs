using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Labs_2025.Lab6
{
    public partial class frmLab6 : Form
    {
        public frmLab6()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (frmLogin.isLogin)
            {
                btn_Login.Enabled = false;
                btn_Logout.Enabled = true;
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            btn_Login.Enabled = true;
            btn_Logout.Enabled = false;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
            
        }
    }
}
