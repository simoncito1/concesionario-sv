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
    public partial class comprar : Form
    {
        public comprar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cbcarros.Visible = true;
            cbcamiones.Visible = false;
            cbmotos.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cbcarros.Visible = false;
            cbcamiones.Visible = false;
            cbmotos.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cbcarros.Visible = false;
            cbcamiones.Visible = true;
            cbmotos.Visible = false;
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usuario = "simon";
            catalogo catalogo = new catalogo(usuario);
            catalogo.Show();
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string dato1 = txtmarca.Text;
            string dato2 = txtmodelo.Text;
            string dato3 = txtdocu.Text;
            string dato4 = txtnom.Text;
            string dato5 = txtcontac.Text;
            using (StreamWriter sw = new StreamWriter("compras.xls", true))
            {
                sw.WriteLine($"{dato1}, {dato2}, {dato3}, {dato4}, {dato5}");
            }
            MessageBox.Show("Guardado 👍");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string dato1 = txtmarca.Text;
            string dato2 = txtmodelo.Text;
            string dato3 = txtdocu.Text;
            string dato4 = txtnom.Text;
            string dato5 = txtcontac.Text;
            compras form3 = new compras(dato1, dato2, dato3, dato4, dato5);
            form3.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtcontac.Text = "";
            txtnom.Text = "";
            txtdocu.Text = "";
            txtmodelo.Text = "";
            txtmarca.Text = "";
        }
    }
}

