namespace _3042024
{
    partial class verparquea
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
            dataGridView1 = new DataGridView();
            Propietario = new DataGridViewTextBoxColumn();
            Vehiculo = new DataGridViewTextBoxColumn();
            Docupro = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            regresarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Propietario, Vehiculo, Docupro, Placa });
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 204);
            dataGridView1.TabIndex = 0;
            // 
            // Propietario
            // 
            Propietario.HeaderText = "Propietario";
            Propietario.Name = "Propietario";
            // 
            // Vehiculo
            // 
            Vehiculo.HeaderText = "Vehiculo";
            Vehiculo.Name = "Vehiculo";
            // 
            // Docupro
            // 
            Docupro.HeaderText = "Documento Propietario";
            Docupro.Name = "Docupro";
            // 
            // Placa
            // 
            Placa.HeaderText = "Placa";
            Placa.Name = "Placa";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(470, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { regresarToolStripMenuItem, salirToolStripMenuItem });
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
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(131, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // verparquea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(470, 413);
            ControlBox = false;
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "verparquea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "verparquea";
            Load += verparquea_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Propietario;
        private DataGridViewTextBoxColumn Vehiculo;
        private DataGridViewTextBoxColumn Docupro;
        private DataGridViewTextBoxColumn Placa;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem regresarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}