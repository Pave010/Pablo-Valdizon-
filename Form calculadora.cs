using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double Num1 = double.Parse(txtNum1.Text);
            double Num2 = double.Parse(txtNum2.Text);

            double res = Num1 + Num2;
            txtResultado.Text = res.ToString();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double Num1 = double.Parse(txtNum1.Text);
            double Num2 = double.Parse(txtNum2.Text);

            double res = Num1 / Num2;
            if(Num2 == 0)
            {
                MessageBox.Show("No es posible realizar la division", "ERROR");
            }
            else { txtResultado.Text = res.ToString(); }
           
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double Num1 = double.Parse(txtNum1.Text);
            double Num2 = double.Parse(txtNum2.Text);

            double res = Num1 - Num2;
            txtResultado.Text = res.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double Num1 = double.Parse(txtNum1.Text);
            double Num2 = double.Parse(txtNum2.Text);

            double res = Num1 * Num2;
            txtResultado.Text = res.ToString();
        }
    }
}
