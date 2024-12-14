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
    public partial class personas : Form
    {
        public personas(string usuario)
        {
            InitializeComponent();
            if (usuario != "simon")
            {
                pictureBox2.Visible = false;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //     string[] oscar = File.ReadAllLines("simonvillas.xlsx");
            string dato1 = txtpro.Text;
            string dato2 = txttplavado.Text;
            string dato3 = txtvehi.Text;
            string dato4 = txtdocu.Text;
            string dato5 = txtprecio.Text;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string dato1 = txtpro.Text;
            string dato2 = txttplavado.Text;
            string dato3 = txtvehi.Text;
            string dato4 = txtdocu.Text;
            string dato5 = txtprecio.Text;
            string pr;
            //dataGridView1.Rows.Add(dato1, dato2, dato3, dato4, dato5);

            visualizar form3 = new visualizar(dato1, dato2, dato3, dato4, dato5);
            //form3.txtpro.Text = dato1;
            if (dato2 == "sencillo" && dato3 == "Moto")
            {
                pr = "10.000";
                txtprecio1.Text = pr;
            }
            if (dato2 == "Completo" && dato3 == "Moto")
            {
                pr = "35.000";
                txtprecio1.Text = pr;
            }
            if (dato2 == "sencillo" && dato3 == "Carro")
            {
                pr = "25.000";
                txtprecio1.Text = pr;
            }
            if (dato2 == "Completo" && dato3 == "Carro")
            {
                pr = "80.000";
                txtprecio1.Text = pr; txtprecio1.Text = "80.000";
            }
            dato5 = txtprecio1.Text;
            using (StreamWriter sw = new StreamWriter("lavado.xls", true))
            {
                sw.WriteLine($"{dato1}, {dato2}, {dato3}, {dato4}, {dato5}");
            }
            MessageBox.Show("Guardado 👍");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string dato1 = txtpro.Text;
            string dato2 = txttplavado.Text;
            string dato3 = txtvehi.Text;
            string dato4 = txtdocu.Text;
            string dato5 = txtprecio.Text;
            string pr;
            if (dato2 == "sencillo" && dato3 == "moto")
            {
                pr = "10.000";
                txtprecio1.Text = pr;
            }
            if (dato2 == "Completo" && dato3 == "moto")
            {
                pr = "35.000";
                txtprecio1.Text = pr;
            }
            if (dato2 == "sencillo" && dato3 == "carro")
            {
                pr = "25.000";
                txtprecio1.Text = pr;
            }
            if (dato2 == "Completo" && dato3 == "carro")
            {
                pr = "80.000";
                txtprecio1.Text = pr; txtprecio1.Text = "80.000";
            }
            dato5 = txtprecio1.Text;
            //dataGridView1.Rows.Add(dato1, dato2, dato3, dato4, dato5);

            visualizar form3 = new visualizar(dato1, dato2, dato3, dato4, dato5);
            form3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtdocu.Text = "";
            txtpro.Text = "";
            txttplavado.Text = "";
            txtvehi.Text = "";
            txtprecio.Text = "";    
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
