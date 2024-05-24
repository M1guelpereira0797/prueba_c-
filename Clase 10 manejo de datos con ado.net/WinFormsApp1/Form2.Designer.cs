namespace WinFormsApp1
{
    partial class Form2
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnElimiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(2003, 891);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(225, 69);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(205, 854);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(225, 69);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnElimiar
            // 
            this.btnElimiar.Location = new System.Drawing.Point(1325, 891);
            this.btnElimiar.Name = "btnElimiar";
            this.btnElimiar.Size = new System.Drawing.Size(225, 69);
            this.btnElimiar.TabIndex = 2;
            this.btnElimiar.Text = "Eliminar";
            this.btnElimiar.UseVisualStyleBackColor = true;
            this.btnElimiar.Click += new System.EventHandler(this.btnElimiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(993, 732);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "CORREO ELECTRONICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1242, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1264, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "APELLIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 48);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(593, 341);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 55);
            this.txtNombre.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1545, 732);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 55);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1535, 381);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 55);
            this.txtPassword.TabIndex = 11;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(1488, 114);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(300, 55);
            this.txtUsuario.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(528, 627);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(300, 55);
            this.txtApellido.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(630, 111);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(300, 55);
            this.txtID.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2323, 1045);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElimiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVolver);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVolver;
        private Button btnGuardar;
        private Button btnElimiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private TextBox txtApellido;
        private TextBox txtID;
    }
}