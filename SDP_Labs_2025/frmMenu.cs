using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDP_Labs_2025.Lab1;
using SDP_Labs_2025.Lab2;
using SDP_Labs_2025.Lab3;
using SDP_Labs_2025.Lab4;
using SDP_Labs_2025.Lab5;
using SDP_Labs_2025.Lab6;

namespace SDP_Labs_2025
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            cboLabs.Items.Add("Lab1");
            cboLabs.Items.Add("Lab2A");
            cboLabs.Items.Add("Lab2B");
            cboLabs.Items.Add("Lab2C");
            cboLabs.Items.Add("Lab3A");
            cboLabs.Items.Add("Lab3B");
            cboLabs.Items.Add("Lab3C");
            cboLabs.Items.Add("Lab4");
            cboLabs.Items.Add("Lab5");
            cboLabs.Items.Add("Lab6");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cboLabs.SelectedItem == null)
            {
                return ;
            }
            switch (cboLabs.SelectedItem.ToString())
            {
                case "Lab1":
                    frmLab1 lab1 = new frmLab1();
                    lab1.Show();
                    break;
                case "Lab2A":
                    frmLab2A lab2A = new frmLab2A();
                    lab2A.Show();
                    break;
                case "Lab2B":
                    frmLab2B lab2B = new frmLab2B();
                    lab2B.Show();
                    break;
                case "Lab2C":
                    frmLab2C lab2C = new frmLab2C();
                    lab2C.Show();
                    break;
                case "Lab3A":
                    frmLab3A lab3A = new frmLab3A();
                    lab3A.Show();
                    break;
                case "Lab3B":
                    frmLab3B lab3B = new frmLab3B();
                    lab3B.Show();
                    break;
                case "Lab3C":
                    frmLab3C lab3C = new frmLab3C();
                    lab3C.Show();
                    break;
                case "Lab4":
                    frmLab4 lab4 = new frmLab4();
                    lab4.Show();
                    break;
                case "Lab5":
                    frmLab5 lab5 = new frmLab5();
                    lab5.Show();
                    break;
                case "Lab6":
                    frmLab6 lab6 = new frmLab6();
                    lab6.Show();
                    break;
            }
        }
    }
}
