using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Labs_2025.Lab2
{
    public partial class frmLab2B : Form
    {
        public frmLab2B()
        {
            InitializeComponent();
        }

        private void lblCloudy_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = true;
            picSuny.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            lblMessage.Text = "It’s going to be a Cloudy day today, " + name_input.Text;
        }

        private void lblRainy_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picSuny.Visible = false;
            picRainy.Visible = true;
            picSnowy.Visible = false;
            lblMessage.Text = "It’s going to be a Rainy day today, " + name_input.Text;
        }

        private void lblSuny_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picSuny.Visible = true;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            lblMessage.Text = "It’s going to be a Suny day today, " + name_input.Text;
        }

        private void lblSnowy_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picSuny.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = true;
            lblMessage.Text = "It’s going to be a Snowy day today, " + name_input.Text;
        }
    }
}
