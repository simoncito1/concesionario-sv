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
    public partial class catalogo : Form
    {
        public catalogo(string usuario)
        {
            InitializeComponent();
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
        private void otrosServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ussuario = "simon";
            servicios servicios = new servicios(ussuario);
            servicios.Show();
            this.Hide();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ussuario = "simon";
            inicio inicio = new inicio(ussuario);
            inicio.Show();
            this.Hide();
        }

        private void verVehiculosPorMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Xmarca Xmarca = new Xmarca();
            Xmarca.Show();
            this.Hide();
        }

        private void catalogo_Load(object sender, EventArgs e)
        {
            //mostrar
            pcbmoto1.Visible = true;
            pcbmoto3.Visible = true;
            pcbmoto8.Visible = true;
            pcbmoto10.Visible = true;
            //-
            pcbcarro2.Visible = true;
            pcbcarro4.Visible = true;
            pcbcarro7.Visible = true;
            pcbcarro12.Visible = true;
            //-
            pcbcamion5.Visible = true;
            pcbcamion6.Visible = true;
            pcbcamion9.Visible = true;
            pcbcamion11.Visible = true;
            //esconder
            pcbmoto2.Visible = false;
            pcbmoto4.Visible = false;
            pcbmoto7.Visible = false;
            pcbmoto6.Visible = false;
            pcbmoto5.Visible = false;
            pcbmoto12.Visible = false;
            pcbmoto11.Visible = false;
            pcbmoto9.Visible = false;
            //-
            pcbcamion1.Visible = false;
            pcbcamion2.Visible = false;
            pcbcamion3.Visible = false;
            pcbcamion4.Visible = false;
            pcbcamion7.Visible = false;
            pcbcamion8.Visible = false;
            pcbcamion10.Visible = false;
            pcbcamion12.Visible = false;
            //-
            pcbcarro1.Visible = false;
            pcbcarro3.Visible = false;
            pcbcarro5.Visible = false;
            pcbcarro6.Visible = false;
            pcbcarro8.Visible = false;
            pcbcarro9.Visible = false;
            pcbcarro10.Visible = false;
            pcbcarro11.Visible = false;
        }

        private void motosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pcbmoto1.Visible = true;
            pcbmoto2.Visible = true;
            pcbmoto3.Visible = true;
            pcbmoto4.Visible = true;
            pcbmoto8.Visible = true;
            pcbmoto7.Visible = true;
            pcbmoto6.Visible = true;
            pcbmoto5.Visible = true;
            pcbmoto12.Visible = true;
            pcbmoto11.Visible = true;
            pcbmoto10.Visible = true;
            pcbmoto9.Visible = true;
            //esconder 
            pcbcarro1.Visible = false;
            pcbcarro2.Visible = false;
            pcbcarro3.Visible = false;
            pcbcarro4.Visible = false;
            pcbcarro5.Visible = false;
            pcbcarro6.Visible = false;
            pcbcarro7.Visible = false;
            pcbcarro8.Visible = false;
            pcbcarro9.Visible = false;
            pcbcarro10.Visible = false;
            pcbcarro11.Visible = false;
            pcbcarro12.Visible = false;
            //--
            pcbcamion1.Visible = false;
            pcbcamion2.Visible = false;
            pcbcamion3.Visible = false;
            pcbcamion4.Visible = false;
            pcbcamion5.Visible = false;
            pcbcamion6.Visible = false;
            pcbcamion7.Visible = false;
            pcbcamion8.Visible = false;
            pcbcamion9.Visible = false;
            pcbcamion10.Visible = false;
            pcbcamion11.Visible = false;
            pcbcamion12.Visible = false;
        }


        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mostrar
            pcbcarro1.Visible = true;
            pcbcarro2.Visible = true;
            pcbcarro3.Visible = true;
            pcbcarro4.Visible = true;
            pcbcarro5.Visible = true;
            pcbcarro6.Visible = true;
            pcbcarro7.Visible = true;
            pcbcarro8.Visible = true;
            pcbcarro9.Visible = true;
            pcbcarro10.Visible = true;
            pcbcarro11.Visible = true;
            pcbcarro12.Visible = true;
            // esconder
            pcbmoto1.Visible = false;
            pcbmoto2.Visible = false;
            pcbmoto3.Visible = false;
            pcbmoto4.Visible = false;
            pcbmoto8.Visible = false;
            pcbmoto7.Visible = false;
            pcbmoto6.Visible = false;
            pcbmoto5.Visible = false;
            pcbmoto12.Visible = false;
            pcbmoto11.Visible = false;
            pcbmoto10.Visible = false;
            pcbmoto9.Visible = false;
            //--
            pcbcamion1.Visible = false;
            pcbcamion2.Visible = false;
            pcbcamion3.Visible = false;
            pcbcamion4.Visible = false;
            pcbcamion5.Visible = false;
            pcbcamion6.Visible = false;
            pcbcamion7.Visible = false;
            pcbcamion8.Visible = false;
            pcbcamion9.Visible = false;
            pcbcamion10.Visible = false;
            pcbcamion11.Visible = false;
            pcbcamion12.Visible = false;
        }

        private void camionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pcbcamion1.Visible = true;
            pcbcamion2.Visible = true;
            pcbcamion3.Visible = true;
            pcbcamion4.Visible = true;
            pcbcamion5.Visible = true;
            pcbcamion6.Visible = true;
            pcbcamion7.Visible = true;
            pcbcamion8.Visible = true;
            pcbcamion9.Visible = true;
            pcbcamion10.Visible = true;
            pcbcamion11.Visible = true;
            pcbcamion12.Visible = true;
            //esconder
            pcbmoto1.Visible = false;
            pcbmoto2.Visible = false;
            pcbmoto3.Visible = false;
            pcbmoto4.Visible = false;
            pcbmoto8.Visible = false;
            pcbmoto7.Visible = false;
            pcbmoto6.Visible = false;
            pcbmoto5.Visible = false;
            pcbmoto12.Visible = false;
            pcbmoto11.Visible = false;
            pcbmoto10.Visible = false;
            pcbmoto9.Visible = false;
            //--
            pcbcarro1.Visible = false;
            pcbcarro2.Visible = false;
            pcbcarro3.Visible = false;
            pcbcarro4.Visible = false;
            pcbcarro5.Visible = false;
            pcbcarro6.Visible = false;
            pcbcarro7.Visible = false;
            pcbcarro8.Visible = false;
            pcbcarro9.Visible = false;
            pcbcarro10.Visible = false;
            pcbcarro11.Visible = false;
            pcbcarro12.Visible = false;
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            comprar comprar = new comprar();
            comprar.Show();
            this.Hide();
        }
    }
}
