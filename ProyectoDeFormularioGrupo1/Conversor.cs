using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoDeFormularioGrupo1
{
    public partial class Conversor : Form
    { 
        public Conversor()
        {
            InitializeComponent();
        }

        private void Conversor_Load(object sender, EventArgs e)
        {
        }

        private void cmdconvertir_Click(object sender, EventArgs e)
        {
            double val;
            if (cbxentrada.Text == "Milimetros" & cbxsalida.Text == "Milimetros")
            {
                val = double.Parse(txtvalor.Text);
                lblr.Text = val.ToString();
                lblum.Text = "mm";

            }

            if (cbxentrada.Text == "Milimetros" & cbxsalida.Text == "Centimetros")
            {
                val = double.Parse(txtvalor.Text);
                val = val / 10;
                lblr.Text = val.ToString();
                lblum.Text = "cm";
            }
            if (cbxentrada.Text == "Milimetros" & cbxsalida.Text == "Metros")
            {
                val = double.Parse(txtvalor.Text);
                val = val / 1000;
                lblr.Text = val.ToString();
                lblum.Text = "m";
            }
            if (cbxentrada.Text == "Milimetros" & cbxsalida.Text == "Kilometros")
            {
                val = double.Parse(txtvalor.Text);
                val = val / 1000000;
                lblr.Text = val.ToString();
                lblum.Text = "km";
            }
            if (cbxentrada.Text == "Centimetros" & cbxsalida.Text == "Milimetros")
            {
                val = double.Parse(txtvalor.Text);
                val = val * 10;
                lblr.Text = val.ToString();
                lblum.Text = "mm";
            }
            if (cbxentrada.Text == "Centimetros" & cbxsalida.Text == "Centimetros")
            {
                val = double.Parse(txtvalor.Text);
                lblr.Text = val.ToString();
                lblum.Text = "Cm";
            }
            if (cbxentrada.Text == "Centimetros" & cbxsalida.Text == "Metros")
            {
                val = double.Parse(txtvalor.Text);
                val = val / 100;
                lblr.Text = val.ToString();
                lblum.Text = "M";
            }
            if (cbxentrada.Text == "Centimetros" & cbxsalida.Text == "Kilometros")
            {
                val = double.Parse(txtvalor.Text);
                val = val / 100000;
                lblr.Text = val.ToString();
                lblum.Text = "km";
            }

            if (cbxentrada.Text == "Metros" & cbxsalida.Text == "Milimetros")
            {
                val = double.Parse(txtvalor.Text);
                val = val * 1000;
                lblr.Text = val.ToString();
                lblum.Text = "mm";

            }

            if (cbxentrada.Text == "Metros" & cbxsalida.Text == "Centimetros")
            {
                val = double.Parse(txtvalor.Text);
                val = val * 100;
                lblr.Text = val.ToString();
                lblum.Text = "Cm";
            }
            if (cbxentrada.Text == "Metros" & cbxsalida.Text == "Metros")
            {
                val = double.Parse(txtvalor.Text);
                lblr.Text = val.ToString();
                lblum.Text = "M";
            }
            if (cbxentrada.Text == "Metros" & cbxsalida.Text == "Kilometros")
            {
                val = double.Parse(txtvalor.Text);
                val = val / 1000;
                lblr.Text = val.ToString();
                lblum.Text = "km";
            }

            if (cbxentrada.Text == "Kilometros" & cbxsalida.Text == "Milimetros")
            {
                val = double.Parse(txtvalor.Text);
                val = val * 10;
                lblr.Text = val.ToString();
                lblum.Text = "mm";
            }
            if (cbxentrada.Text == "Kilometros" & cbxsalida.Text == "Centimetros")
            {
                val = double.Parse(txtvalor.Text);
                lblr.Text = val.ToString();
                lblum.Text = "Cm";
            }
            if (cbxentrada.Text == "Kilometros" & cbxsalida.Text == "Metros")
            {
                val = double.Parse(txtvalor.Text);
                val = val / 100;
                lblr.Text = val.ToString();
                lblum.Text = "M";
            }
            if (cbxentrada.Text == "Kilometros" & cbxsalida.Text == "Kilometros")
            {
                val = double.Parse(txtvalor.Text);
                val = val / 100000;
                lblr.Text = val.ToString();
                lblum.Text = "km";
            }
        }
           

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 Calc = new Form1();
            Calc.Show();
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();
            ayuda.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 acerca = new AboutBox1();
            acerca.ShowDialog();
        }

        private void cmdnuevo_Click(object sender, EventArgs e)
        {
            lblr.Text = "";
            lblum.Text = "";
            txtvalor.Text = "";

        }
    }
}


        

      