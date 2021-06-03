using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtN1.Text = " ";
            txtN2.Text = " ";
            lblTotal.Text = " ";
            rbtDividir.Checked = false;
            rbtMultiplicar.Checked = false;
            rbtRestar.Checked = false;
            rbtSumar.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txtN1.Text);
            double N2 = Convert.ToDouble(txtN2.Text);
            double dividir = 0.0;
            double multiplicar = 0.0;
            double suma = 0.0;
            double resta = 0.0;
            if(rbtDividir.Checked == true)
            {
                dividir = N1 / N2;
                lblTotal.Text = dividir.ToString();
            }
            if (rbtMultiplicar.Checked == true)
            {
                multiplicar = N1 * N2;
                lblTotal.Text = multiplicar.ToString();
            }
            if (rbtSumar.Checked == true)
            {
                suma = N1 + N2;
                lblTotal.Text = suma.ToString();
            }
            if (rbtRestar.Checked == true)
            {
                resta = N1 - N2;
                lblTotal.Text = resta.ToString();
            }
        }
    }
}
