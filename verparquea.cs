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
    public partial class verparquea : Form
    {
        public verparquea(string dato1, string dato2, string dato3, string dato4)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(dato1, dato2, dato3, dato4);
        }

        private void verparquea_Load(object sender, EventArgs e)
        {
            string[] oscar = File.ReadAllLines("parqueadero.xls");
            foreach (string oscar2 in oscar)
            {
                string[] values = oscar2.Split(',');
                dataGridView1.Rows.Add(values);
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usuario = "simon";
            servicios servicios = new servicios(usuario);
            servicios.Show();
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
