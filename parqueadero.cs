using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _3042024
{
    public partial class parqueadero : Form
    {
        public parqueadero(string usuario)
        {
            if (usuario != "simon")
            {
                pictureBox2.Visible = false;
            }
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtdocu.Text = "";
            txtpro.Text = "";
            txtvehi.Text = "";
            txtplaca.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string dato1 = txtpro.Text;
            string dato2 = txtvehi.Text;
            string dato3 = txtdocu.Text;
            string dato4 = txtprecio.Text;
            //dataGridView1.Rows.Add(dato1, dato2, dato3, dato4, dato5);

            verparquea form3 = new verparquea(dato1, dato2, dato3, dato4);
            //form3.txtpro.Text = dato1;

            using (StreamWriter sw = new StreamWriter("parqueadero.xls", true))
            {
                sw.WriteLine($"{dato1}, {dato2}, {dato3}, {dato4}");
            }
            MessageBox.Show("Guardado 👍");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string dato1 = txtpro.Text;
            string dato2 = txtvehi.Text;
            string dato3 = txtdocu.Text;
            string dato4 = txtplaca.Text;
            verparquea form3 = new verparquea(dato1, dato2, dato3, dato4);
            form3.Show();
            this.Hide();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usuario = "simon";
            servicios servicios = new servicios(usuario);
            servicios.Show();
            this.Hide();
        }
    }
}

