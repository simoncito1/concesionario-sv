namespace _3042024
{
    partial class personas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            txtvehi = new ComboBox();
            txttplavado = new ComboBox();
            txtprecio = new Label();
            label4 = new Label();
            txtprecio1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtdocu = new TextBox();
            txtpro = new TextBox();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            regresarToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(159, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.images1;
            pictureBox3.Location = new Point(30, 219);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 192, 128);
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.pO3OY;
            pictureBox2.Location = new Point(30, 124);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(28, 36);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(txtvehi);
            groupBox2.Controls.Add(txttplavado);
            groupBox2.Controls.Add(txtprecio);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtprecio1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtdocu);
            groupBox2.Controls.Add(txtpro);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(216, 35);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(486, 333);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicio";
            // 
            // txtvehi
            // 
            txtvehi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvehi.FormattingEnabled = true;
            txtvehi.Items.AddRange(new object[] { "Moto", "Carro" });
            txtvehi.Location = new Point(115, 169);
            txtvehi.Name = "txtvehi";
            txtvehi.Size = new Size(239, 29);
            txtvehi.TabIndex = 14;
            txtvehi.Text = "Selecciona una opcion";
            // 
            // txttplavado
            // 
            txttplavado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttplavado.FormattingEnabled = true;
            txttplavado.Items.AddRange(new object[] { "sencillo", "Completo" });
            txttplavado.Location = new Point(158, 121);
            txttplavado.Margin = new Padding(3, 2, 3, 2);
            txttplavado.Name = "txttplavado";
            txttplavado.Size = new Size(196, 29);
            txttplavado.TabIndex = 13;
            txttplavado.Text = "Selecciona una opcion";
            // 
            // txtprecio
            // 
            txtprecio.AutoSize = true;
            txtprecio.BackColor = Color.White;
            txtprecio.Location = new Point(115, 280);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(0, 21);
            txtprecio.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 278);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 11;
            label4.Text = "Precio:";
            // 
            // txtprecio1
            // 
            txtprecio1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprecio1.Location = new Point(106, 278);
            txtprecio1.Margin = new Padding(3, 2, 3, 2);
            txtprecio1.Name = "txtprecio1";
            txtprecio1.Size = new Size(366, 29);
            txtprecio1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 226);
            label5.Name = "label5";
            label5.Size = new Size(194, 21);
            label5.TabIndex = 9;
            label5.Text = "Documento Propietario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 172);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 7;
            label3.Text = "Vehiculo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 121);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 6;
            label2.Text = "Tipo de lavado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 69);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 5;
            label1.Text = "Nombre De Propietario:";
            // 
            // txtdocu
            // 
            txtdocu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdocu.Location = new Point(228, 229);
            txtdocu.Margin = new Padding(3, 2, 3, 2);
            txtdocu.Name = "txtdocu";
            txtdocu.Size = new Size(244, 29);
            txtdocu.TabIndex = 4;
            // 
            // txtpro
            // 
            txtpro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpro.Location = new Point(228, 69);
            txtpro.Margin = new Padding(3, 2, 3, 2);
            txtpro.Name = "txtpro";
            txtpro.Size = new Size(244, 29);
            txtpro.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(714, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { regresarToolStripMenuItem });
            opcionesToolStripMenuItem.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(79, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // regresarToolStripMenuItem
            // 
            regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            regresarToolStripMenuItem.Size = new Size(131, 22);
            regresarToolStripMenuItem.Text = "Regresar";
            regresarToolStripMenuItem.Click += regresarToolStripMenuItem_Click;
            // 
            // personas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(714, 379);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "personas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personas";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtpro;
        private TextBox txtdocu;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtprecio1;
        private Label txtprecio;
        private ComboBox txttplavado;
        private ComboBox txtvehi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem regresarToolStripMenuItem;
    }
}