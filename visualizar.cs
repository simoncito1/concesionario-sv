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
    public partial class visualizar : Form
    {
        public visualizar(string dato1, string dato2, string dato3, string dato4, string dato5)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(dato1, dato2, dato3, dato4, dato5);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            string[] oscar = File.ReadAllLines("lavado.xls");
            foreach (string oscar2 in oscar)
            {
                string[] values = oscar2.Split(',');
                dataGridView1.Rows.Add(values);
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            login form2 = new login();
            form2.Show();
            this.Hide();
        }

        private void regresarToolStripMenuItem1_Click(object sender, EventArgs e, string usuario)
        {

            personas form2 = new personas(usuario);
            form2.Show();
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

        private void regresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string ussuario = "simon";
            servicios servicios = new servicios(ussuario);
            servicios.Show();
            this.Hide();
        }
    }
}
