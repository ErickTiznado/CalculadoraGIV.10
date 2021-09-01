using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoDeFormularioGrupo1
{
    public partial class calculadoracientifica : Form
    {
        public calculadoracientifica()
        {
            InitializeComponent();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Principal.Text = string.Empty;
        }

        private void MC_button_Click(object sender, EventArgs e)
        {

        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            if (Principal.Text.Length > 1)
            {
                Principal.Text = Principal.Text.Remove(Principal.Text.Length -1, 1);
            }
        }
    }
}
