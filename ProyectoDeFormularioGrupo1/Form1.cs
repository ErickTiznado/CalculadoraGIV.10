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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void conversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta parte todavia no esta lista", "En Desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calculadoraCientificaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta parte todavia no esta lista", "En Desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
    