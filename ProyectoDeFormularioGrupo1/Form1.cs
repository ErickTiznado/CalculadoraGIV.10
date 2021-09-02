using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Calculadora 
//Nathaly Milena Zelaya Caballero
//Julissa Odaly Sosa Flores
//Franklin Stanley Larin Saravia
//Oscar Manuel Lopez Velasquez
//Ana Carolina Guevara Rodriguez 
namespace ProyectoDeFormularioGrupo1
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        String operador;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsDiv obj1 = new Clases.ClsDiv();
        Clases.ClsMult obj2 = new Clases.ClsMult();
        Clases.ClsResta obj3 = new Clases.ClsResta();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "0";
        }

        private void conversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta parte todavia no esta lista", "En Desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calculadoraCientificaToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            CalcCientPanel.Visible = true;
            CalcCientPanel.Enabled = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 Acercade = new AboutBox1();

            Acercade.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            

            Ayuda ayuda = new Ayuda();
            ayuda.ShowDialog();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpanel.Text = txtpanel.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtpanel.Text);
            txtpanel.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtpanel.Text);
            txtpanel.Clear();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtpanel.Text);
            txtpanel.Clear();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtpanel.Text);
            txtpanel.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtpanel.Text);
            double suma;
            double resta;
            double div;
            double mult;
                switch (operador)
            {
                case "+":
                    suma = obj.suma((primero), (segundo));
                    txtpanel.Text = suma.ToString();
                    break;
                case "/":
                    div = obj1.Div((primero), (segundo));
                    txtpanel.Text = div.ToString();
                    break;
                case "*":
                    mult = obj2.Mult((primero), (segundo));
                    txtpanel.Text = mult.ToString();
                    break;
                case "-":
                    resta = obj3.resta((primero), (segundo));
                    txtpanel.Text = resta.ToString();
                    break;

            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtpanel.Clear();
        }

        private void btnf_Click(object sender, EventArgs e)
        {
            if (txtpanel.Text.Length == 1)
                txtpanel.Text = "";
            else
                txtpanel.Text = txtpanel.Text.Substring(0, txtpanel.Text.Length - 1);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            // Limpiar / Vaciar el TextBox
            Principal.Text = string.Empty;
        }

        private void CalcCientPanel_Paint(object sender, PaintEventArgs e)
        {
              

        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            if (Principal.Text.Length > 1)
            {
                Principal.Text = Principal.Text.Remove(Principal.Text.Length - 1, 1);
            }
        }
    }
    }

    
