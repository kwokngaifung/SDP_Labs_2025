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
            updatePicture(picCloudy , "cloudy");
        }

        private void lblRainy_CheckedChanged(object sender, EventArgs e)
        {
            updatePicture(picRainy , "rainy");
        }

        private void lblSuny_CheckedChanged(object sender, EventArgs e)
        {
            updatePicture(picSuny , "suny");
        }

        private void lblSnowy_CheckedChanged(object sender, EventArgs e)
        {
            updatePicture(picSnowy , "snowy");
           
        }

        private void updatePicture(PictureBox pic , string name)
        {
            picCloudy.Visible = false;
            picSuny.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            pic.Visible = true;

            lblMessage.Text = $"It’s going to be a {name} day today, {name_input.Text}";
        }
    }
}
