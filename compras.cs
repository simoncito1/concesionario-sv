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
    public partial class compras : Form
    {
        public compras(string dato1, string dato2, string dato3, string dato4, string dato5)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(dato1, dato2, dato3, dato4, dato5);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void compras_Load(object sender, EventArgs e)
        {
            string[] oscar = File.ReadAllLines("compras.xls");
            foreach (string oscar2 in oscar)
            {
                string[] values = oscar2.Split(',');
                dataGridView1.Rows.Add(values);
            }
        }
    }
}
