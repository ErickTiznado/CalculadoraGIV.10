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
            if ( cbxentrada.Text == "Milimetros" & cbxsalida.Text == "Milimetros" )
            {
                val= double.Parse(txtvalor.Text);
                lblr.Text = val.ToString();
                lblum.Text = "mm";
            }
        }
    }
}


        

      