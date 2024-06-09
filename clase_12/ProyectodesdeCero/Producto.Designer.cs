namespace ProyectodesdeCero
{
    partial class Producto
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVovler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(387, 224);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(186, 224);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVovler
            // 
            this.btnVovler.Location = new System.Drawing.Point(53, 224);
            this.btnVovler.Name = "btnVovler";
            this.btnVovler.Size = new System.Drawing.Size(75, 23);
            this.btnVovler.TabIndex = 2;
            this.btnVovler.Text = "Volver";
            this.btnVovler.UseVisualStyleBackColor = true;
            this.btnVovler.Click += new System.EventHandler(this.btnVovler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio de Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio de venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID Usuario";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(176, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(176, 58);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 23);
            this.txtDescripcion.TabIndex = 10;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(176, 88);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioCosto.TabIndex = 11;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(176, 124);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioVenta.TabIndex = 12;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(176, 154);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            this.txtStock.TabIndex = 13;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(186, 184);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtIdUsuario.TabIndex = 14;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 271);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVovler);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Name = "Producto";
            this.Text = "Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBorrar;
        private Button btnGuardar;
        private Button btnVovler;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private TextBox txtPrecioCosto;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private TextBox txtIdUsuario;
    }
}