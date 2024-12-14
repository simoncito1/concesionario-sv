using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _3042024
{
    public partial class yamaha : Form
    {
        public yamaha()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            detallesMT15 detallesMT15 = new detallesMT15();
            detallesMT15.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xmarca xmarca = new Xmarca();
            xmarca.Show();
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
    }
}
