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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_volta2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new FRMMenu();
            Menu.ShowDialog();
        }

        private void btn_Calcular2_Click(object sender, EventArgs e)
        {
            double valorbase = double.Parse(txt_base.Text);

            double altura = double.Parse(txt_altura.Text);

            double conta = valorbase * altura;

            txt_resultado.Text = conta.ToString();

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txt_resultado.Clear();
            txt_altura.Clear();
            txt_base.Clear();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
