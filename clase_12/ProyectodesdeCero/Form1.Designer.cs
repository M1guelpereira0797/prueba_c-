namespace ProyectodesdeCero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClienteProducto = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienteProducto
            // 
            this.dgvClienteProducto.Location = new System.Drawing.Point(0, 0);
            this.dgvClienteProducto.Name = "dgvClienteProducto";
            this.dgvClienteProducto.Size = new System.Drawing.Size(240, 150);
            this.dgvClienteProducto.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(-1, 73);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.Size = new System.Drawing.Size(693, 275);
            this.dgvCliente.TabIndex = 0;
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.Location = new System.Drawing.Point(531, 26);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(112, 23);
            this.btnAgregar1.TabIndex = 1;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = true;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Usuario ",
            "Producto"});
            this.comboBox1.Location = new System.Drawing.Point(22, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(693, 351);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAgregar1);
            this.Controls.Add(this.dgvCliente);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        private void DgvCliente_CelltClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dgvClienteProducto;
        private Button btnAgregar;
        private DataGridView dgvCliente;
        private Button btnAgregar1;
        private ComboBox comboBox1;
    }
}