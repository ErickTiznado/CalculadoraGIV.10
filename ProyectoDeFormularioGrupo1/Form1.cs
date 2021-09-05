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
        double resultado;
        double memoria;
        String operador;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsDiv obj1 = new Clases.ClsDiv();
        Clases.ClsMult obj2 = new Clases.ClsMult();
        Clases.ClsResta obj3 = new Clases.ClsResta();
        Clases.Clssin obj4 = new Clases.Clssin();
        Clases.Clscos obj5 = new Clases.Clscos();
        Clases.Clstan obj6 = new Clases.Clstan();
        Clases.Clsec obj7 = new Clases.Clsec();
        Clases.Clscot obj8 = new Clases.Clscot();
        Clases.Clscsc obj9 = new Clases.Clscsc();

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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            log_Button.Visible = true;
            sin_Button.Visible = true;
            cos_Button.Visible = true;
            tan_Button.Visible = true;
            NatLog_Button.Visible = true;
        }

        private void log_Button_Click(object sender, EventArgs e)
        {
            double log;
            primero = double.Parse(txtpanel.Text);
            log = Math.Log10(primero);

            txtpanel.Clear();
            txtpanel.Text = log.ToString();
        }

        private void sin_Button_Click(object sender, EventArgs e)
        {
            double sin;
            double resultado;
            primero = double.Parse(txtpanel.Text);
            sin = primero * (Math.PI/180);
            resultado = Math.Sin(sin);

            txtpanel.Clear();
            txtpanel.Text = resultado.ToString();
        }

        private void cos_Button_Click(object sender, EventArgs e)
        {
            double cos;
            double resultado;
            primero = double.Parse(txtpanel.Text);
            cos = primero * (Math.PI / 180);
            resultado = Math.Cos(cos);

            txtpanel.Clear();
            txtpanel.Text = resultado.ToString();
        }

        private void tan_Button_Click(object sender, EventArgs e)
        {
            double tan;
            double resultado;
            primero = double.Parse(txtpanel.Text);
            tan = primero * (Math.PI / 180);
            resultado = Math.Tan(tan);

            txtpanel.Clear();
            txtpanel.Text = resultado.ToString();
        }

        private void NatLog_Button_Click(object sender, EventArgs e)
        {
            double lg;
            primero = double.Parse(txtpanel.Text);
            lg = Math.Log(primero);

            txtpanel.Clear();
            txtpanel.Text = lg.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Conversor conve = new Conversor();
            conve.Show();
            this.Close();
        }
    }
}

    
