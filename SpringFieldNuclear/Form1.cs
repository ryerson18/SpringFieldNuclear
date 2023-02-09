using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SpringFieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reactoer1green.BackColor = Color.Red;
            Reactoer2green.BackColor = Color.Red;

            OutputLabel.Text = "Meltdown Happening!!!";

          Refresh();
            Thread.Sleep(1000);

            Reactoer1green.BackColor = Color.Purple;
            Reactoer2green.BackColor = Color.Purple;

            Refresh();
            Thread.Sleep(1000);

            Reactoer1green.BackColor = Color.Red;
            Reactoer2green.BackColor = Color.Red;


            Refresh();
            Thread.Sleep(1000);

            Reactoer1green.BackColor = Color.Purple;
            Reactoer2green.BackColor = Color.Purple;

            Refresh();
            Thread.Sleep(1000);

            Reactoer1green.BackColor = Color.Red;
            Reactoer2green.BackColor = Color.Red;














        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void Reactoer2green_Click(object sender, EventArgs e)
        {

        }
    }
}
