using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Sakriji.Checked)
            {
                textBox1.Hide();
            }
            else
            {
                textBox1.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dorucak_CheckedChanged(object sender, EventArgs e)
        {
            if (Dorucak.Checked)
            {
                textBox1.AppendText("Dorucak");
            }
        }

        private void Rucak_CheckedChanged(object sender, EventArgs e)
        {
            if (Rucak.Checked)
            {
                textBox1.AppendText("\nRucak");
            }
        }

        private void Vecera_CheckedChanged(object sender, EventArgs e)
        {
            if (Vecera.Checked)
            {
                textBox1.AppendText("\nVecera");
            }
        }
    }
}

