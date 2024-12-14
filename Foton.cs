using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Foton : Form
    {
        public Foton()
        {
            InitializeComponent();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Xmarca Xmarca = new Xmarca();
            //Xmarca.Show();
            //this.Hide();
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
