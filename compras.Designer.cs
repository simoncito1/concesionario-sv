namespace _3042024
{
    partial class compras
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
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            DocumentoComprador = new DataGridViewTextBoxColumn();
            nomcomprador = new DataGridViewTextBoxColumn();
            Contacto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Marca, Modelo, DocumentoComprador, nomcomprador, Contacto });
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(605, 326);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            // 
            // DocumentoComprador
            // 
            DocumentoComprador.HeaderText = "Documento Comprador";
            DocumentoComprador.Name = "DocumentoComprador";
            // 
            // nomcomprador
            // 
            nomcomprador.HeaderText = "Nombre Comprador";
            nomcomprador.Name = "nomcomprador";
            // 
            // Contacto
            // 
            Contacto.HeaderText = "Contacto";
            Contacto.Name = "Contacto";
            // 
            // compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(641, 396);
            Controls.Add(dataGridView1);
            Name = "compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "compras";
            Load += compras_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn DocumentoComprador;
        private DataGridViewTextBoxColumn nomcomprador;
        private DataGridViewTextBoxColumn Contacto;
    }
}