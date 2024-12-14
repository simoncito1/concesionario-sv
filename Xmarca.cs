using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto;
using wiñiam;

namespace _3042024
{
    public partial class Xmarca : Form
    {
        public Xmarca()
        {
            InitializeComponent();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ussuario = "simon";
            catalogo cata = new catalogo(ussuario);
            cata.Show();
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

                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bmw bmw = new bmw();
            bmw.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Kawasaki kawasaki = new Kawasaki();
            kawasaki.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            nizzan nizzan = new nizzan();
            nizzan.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Foton foton = new Foton();
            foton.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            daf daf = new daf();
            daf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            yamaha yamaha = new yamaha();
            yamaha.Show();
            this.Hide();
        }
    }
}
