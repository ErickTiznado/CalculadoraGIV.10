using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeFormularioGrupo1
{
    public partial class calculadoracientifica : Form
    {
        public calculadoracientifica()
        {
            InitializeComponent();
        }

        //Declaracion de variables

        double num1, num2, Memory;
        string operation;


        Operations.cos ObjCos = new Operations.cos();

        


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

        private void Button_1_Click(object sender, EventArgs e)
        {
            Principal.Text += "1";
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            Principal.Text += "2";
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            Principal.Text += "3";
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            Principal.Text += "4";
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            Principal.Text += "5";
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            Principal.Text += "6";
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            Principal.Text += "7";
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            Principal.Text += "8";
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            Principal.Text += "9";
        }

        private void cos_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            Principal.Text += "0";
        }

        private void calculadoracientifica_Load(object sender, EventArgs e)
        {

        }
    }
}
