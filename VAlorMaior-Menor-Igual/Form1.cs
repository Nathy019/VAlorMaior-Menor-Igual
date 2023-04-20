using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAlorMaior_Menor_Igual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtValor1.Text);
            int valor2 = Convert.ToInt32(txtValor2.Text);
            
            if(valor1 > valor2)
            {
                MessageBox.Show("Valor maior = " + valor1);
                MessageBox.Show("Valor menor" + valor2);
            }
            else if(valor1 < valor2)
            {
                MessageBox.Show("Valor menor =" + valor2);
                MessageBox.Show("Valor maior = " + valor1);
            }
            else if (valor1 == valor2)
            {
                MessageBox.Show("Igual");
            }
        }
    }
}
