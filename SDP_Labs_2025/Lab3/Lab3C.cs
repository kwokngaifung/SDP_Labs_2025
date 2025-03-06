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
    public partial class frmLab3C : Form
    {
        public frmLab3C()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox1.Items.IndexOf(listBox2.Items[listBox2.Items.Count - i - 1]) == -1)
                {
                    listBox1.Items.Add(listBox2.Items[listBox2.Items.Count - i - 1]);
                }
            }

            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Shop:{listBox1.Items.Count} Cart:{listBox2.Items.Count} \nShop + Cart = {listBox1.Items.Count + listBox2.Items.Count}");
        }
    }
}
