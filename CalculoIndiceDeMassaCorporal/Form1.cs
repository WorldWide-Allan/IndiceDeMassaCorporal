using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIndiceDeMassaCorporal
{
    public partial class Form1 : Form
    {
        Double peso, altura, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btt_limpar_Click(object sender, EventArgs e)
        {
            txt_altura.Text = " ";
            txt_peso.Text = " ";
            lbl_resultado.Text = " ";
            lbl_01.BackColor = Color.Transparent;
            lbl_02.BackColor = Color.Transparent;
            lbl_03.BackColor = Color.Transparent;
            lbl_04.BackColor = Color.Transparent;
            lbl_05.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btt_calcular_Click(object sender, EventArgs e)
        {
            peso = Convert.ToSingle(txt_peso.Text);
            altura = Convert.ToSingle(txt_altura.Text);
            resultado = (peso/(altura * altura));
            lbl_resultado.Text = Convert.ToString("Seu IMC: " + resultado);
            if (resultado < 18.5) 
            {
                lbl_01.BackColor = Color.LightBlue;
            }
            else if (resultado >= 18.5 && resultado < 25)
            {
                lbl_02.BackColor = Color.LightGreen;
            }
            else if (resultado >= 25 && resultado < 30)
            {
                lbl_03.BackColor = Color.Yellow;
            }
            else if (resultado >= 30 && resultado < 40)
            {
                lbl_04.BackColor = Color.Orange;
            }
            else
            {
                lbl_05.BackColor = Color.Red;
            }
            
        }
    }
}
