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
        If cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "mm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) / 10
            lblum.Text = "cm"
            
        }
    }
}


        

      