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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_chama2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new FRMMenu();
            Menu.ShowDialog();
        }


        private void Calcular_Click(object sender, EventArgs e)
        {
            double valorlado = double.Parse(txt_valor.Text);

            double conta = valorlado * valorlado;

            txt_resultado.Text = conta.ToString();
            
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_resultado.Clear();
            txt_valor.Clear();  
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
