using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_alpha.Text = (string)textBox_alpha.Text;
            label_beta.Text = (string)textBox_beta.Text;
            label_mincutoff.Text = (string)textBox_mincutoff.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_alpha.Text = "0.3";
            textBox_beta.Text = "0.03";
            textBox_mincutoff.Text = "0.007";
        }
    }
}
