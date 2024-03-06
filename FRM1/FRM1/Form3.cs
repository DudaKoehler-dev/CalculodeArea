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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new FRMMenu();
            Menu.ShowDialog();
        }
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double valorbase = double.Parse(txt_lado.Text);

            double altura = double.Parse(txt_altura.Text);

            double conta = (valorbase * altura)/2;

            txt_resultado.Text = conta.ToString();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_altura.Clear();
            txt_resultado.Clear();
            txt_lado.Clear();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
