
namespace wiñiam
{
    public partial class bmw : Form
    {
        public bmw()
        {
            InitializeComponent();
        }
        private void regresarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
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
