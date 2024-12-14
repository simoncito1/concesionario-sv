using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3042024
{
    public partial class servicios : Form
    {
        public servicios(string usuario)
        {

            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string usuario = "simon";
            personas lavado = new personas(usuario);
            lavado.Show();
            this.Hide();
        }

        private void servicios_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            string ussuario = "simon";
            parqueadero pq = new parqueadero(ussuario);
            pq.Show();
            this.Hide();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ussuario = "simon";
            inicio inicio = new inicio(ussuario);
            inicio.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message =
              "Deseas Salir";
            const string caption = "Porque te vas bro";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            if (result == DialogResult.No)
            {
                //this.Hide();
                return;
            }
        }
    }
}
