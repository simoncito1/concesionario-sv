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
    public partial class inicio : Form
    {
        public inicio(string usuario)
        {
            InitializeComponent();
        }



        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string usuario = "simon";
            catalogo catalogo = new catalogo(usuario);
            catalogo.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string usuario = "simon";
            servicios servicios = new servicios(usuario);
            servicios.Show();
            this.Hide();
        }

        //this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
    }
}
