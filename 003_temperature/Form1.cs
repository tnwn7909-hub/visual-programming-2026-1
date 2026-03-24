using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            double c = double.Parse(txtC.Text);
            double f = c * 9.9 / 5 + 32;
            txtF.Text = f.ToString("F1");
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            double f = double.Parse(txtF.Text);
            double c = (f - 32) * 5 / 9.0;
            txtF.Text = c.ToString("F1");

        }
    }
}
