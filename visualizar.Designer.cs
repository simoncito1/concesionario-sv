
namespace _3042024
{
    partial class visualizar
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
            txtpro = new DataGridViewTextBoxColumn();
            Tplavado = new DataGridViewTextBoxColumn();
            txtvehi = new DataGridViewTextBoxColumn();
            txtdocu = new DataGridViewTextBoxColumn();
            txtprecio = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem1 = new ToolStripMenuItem();
            regresarToolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtpro, Tplavado, txtvehi, txtdocu, txtprecio });
            dataGridView1.Location = new Point(13, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(676, 304);
            dataGridView1.TabIndex = 1;
            // 
            // txtpro
            // 
            txtpro.HeaderText = "Propietario";
            txtpro.MinimumWidth = 6;
            txtpro.Name = "txtpro";
            txtpro.ReadOnly = true;
            txtpro.Width = 130;
            // 
            // Tplavado
            // 
            Tplavado.HeaderText = "Tipo de Lavado";
            Tplavado.MinimumWidth = 6;
            Tplavado.Name = "Tplavado";
            Tplavado.ReadOnly = true;
            Tplavado.Width = 125;
            // 
            // txtvehi
            // 
            txtvehi.HeaderText = "Vehiculo";
            txtvehi.MinimumWidth = 6;
            txtvehi.Name = "txtvehi";
            txtvehi.ReadOnly = true;
            txtvehi.Width = 125;
            // 
            // txtdocu
            // 
            txtdocu.HeaderText = "Documento Propietario";
            txtdocu.MinimumWidth = 6;
            txtdocu.Name = "txtdocu";
            txtdocu.ReadOnly = true;
            txtdocu.Width = 125;
            // 
            // txtprecio
            // 
            txtprecio.HeaderText = "Precio";
            txtprecio.MinimumWidth = 6;
            txtprecio.Name = "txtprecio";
            txtprecio.ReadOnly = true;
            txtprecio.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem1, regresarToolStripMenuItem1, salirToolStripMenuItem });
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(79, 20);
            cerrarSesionToolStripMenuItem.Text = "Opciones";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            cerrarSesionToolStripMenuItem1.Size = new Size(180, 22);
            cerrarSesionToolStripMenuItem1.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem1.Click += cerrarSesionToolStripMenuItem1_Click;
            // 
            // regresarToolStripMenuItem1
            // 
            regresarToolStripMenuItem1.Name = "regresarToolStripMenuItem1";
            regresarToolStripMenuItem1.Size = new Size(180, 22);
            regresarToolStripMenuItem1.Text = "Regresar";
            regresarToolStripMenuItem1.Click += regresarToolStripMenuItem1_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // visualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "visualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Visualizar";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn txtpro;
        private DataGridViewTextBoxColumn Tplavado;
        private DataGridViewTextBoxColumn txtvehi;
        private DataGridViewTextBoxColumn txtdocu;
        private DataGridViewTextBoxColumn txtprecio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem1;
        private ToolStripMenuItem regresarToolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}