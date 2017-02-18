using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraJr
{
    public partial class Calc1 : Form
    {
        public Calc1()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;

            if ((txtValor1.Text == "") || (txtValor2.Text == ""))
            {
                MessageBox.Show("Informe um valor");
            }

            else
            {

                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = valor1 + valor2;
                lblResultado.Text = (resultado.ToString());
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {

            Double valor1, valor2, resultado;

            if ((txtValor1.Text == "") || (txtValor2.Text == ""))
            {
                MessageBox.Show("Informe um valor");
            }
            else
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = valor1 - valor2;
                lblResultado.Text = (resultado.ToString());
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {

            Double valor1, valor2, resultado;

            if ((txtValor1.Text == "") || (txtValor2.Text == ""))
            {
                MessageBox.Show("Informe um valor");
            }
            else
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = valor1 * valor2;
                lblResultado.Text = (resultado.ToString());
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {

            Double valor1, valor2, resultado;
            if ((txtValor1.Text == "") || (txtValor2.Text == ""))
            {
                MessageBox.Show("Informe um valor");
            }
            else
            {
            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);

            resultado = valor1 / valor2;
            lblResultado.Text = (resultado.ToString());
            }
        }
    }
}
