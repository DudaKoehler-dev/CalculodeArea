using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRM1
{
    public partial class FRMMenu : Form
    {
        public FRMMenu()
        {
            InitializeComponent();
        }

        private void btn_quadrado_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void btn_retangulo_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.ShowDialog();
        }

        private void Trapezio_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.ShowDialog();
        }

        private void trapézioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void triânguloToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void calculoDeAreasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
