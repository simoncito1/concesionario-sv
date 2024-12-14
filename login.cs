namespace _3042024
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string usuario = txtusu.Text;
            string contraseña = txtcon.Text;
            if (usuario == "simon")
            {

                if (contraseña == "admin")
                {

                    inicio form2 = new inicio(usuario);
                    personas personas = new personas(usuario);
                    servicios servicios = new servicios(usuario);
                    catalogo catalogo = new catalogo(usuario);
                    parqueadero parqueadero = new parqueadero(usuario);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos");
                    txtcon.Text = "";
                    txtusu.Text = "";
                }
            }
            if (usuario == "fredy")
            {

                if (contraseña == "1234")
                {

                    inicio form2 = new inicio(usuario);
                    personas personas = new personas(usuario);
                    servicios servicios = new servicios(usuario);
                    catalogo catalogo = new catalogo(usuario);
                    parqueadero parqueadero = new parqueadero(usuario);
                    form2.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Usuario o Contraseña incorrectos");
                    txtcon.Text = "";
                    txtusu.Text = "";
                }
            }
            if (usuario != "simon" && usuario != "fredy")
            {
                if (contraseña != "messi" && contraseña != "1234")
                {


                    MessageBox.Show("Usuario o Contraseña incorrectos");
                    txtcon.Text = "";
                    txtusu.Text = "";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                txtcon.PasswordChar = '\0';
            }
            else
            {
                txtcon.PasswordChar = '*';

            }
        }
    }
}
