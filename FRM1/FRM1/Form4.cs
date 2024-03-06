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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new FRMMenu();
            Menu.ShowDialog();
        }
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double valorbase = double.Parse(txt_basemaior.Text);

            double valorbase2 = double.Parse(txt_basemenor.Text);

            double altura = double.Parse(txt_altura.Text);

            double conta = ((valorbase + valorbase2) * altura)/ 2;

            txt_resultado.Text = conta.ToString();
        }


        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_basemenor.Clear();
            txt_altura.Clear();
            txt_resultado.Clear();
            txt_basemaior.Clear();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
