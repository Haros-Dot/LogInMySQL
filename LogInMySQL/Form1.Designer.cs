namespace LogInMySQL
{
    partial class FormRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lbconfirmapass = new System.Windows.Forms.Label();
            this.txtconpassword = new System.Windows.Forms.TextBox();
            this.lbnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btniniciarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.Location = new System.Drawing.Point(51, 41);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(68, 20);
            this.lbusuario.TabIndex = 0;
            this.lbusuario.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(217, 41);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(145, 26);
            this.txtusuario.TabIndex = 1;
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Location = new System.Drawing.Point(51, 95);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(92, 20);
            this.lbpassword.TabIndex = 0;
            this.lbpassword.Text = "Contraseña";
            this.lbpassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(217, 95);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(145, 26);
            this.txtpassword.TabIndex = 1;
            // 
            // lbconfirmapass
            // 
            this.lbconfirmapass.AutoSize = true;
            this.lbconfirmapass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconfirmapass.Location = new System.Drawing.Point(51, 149);
            this.lbconfirmapass.Name = "lbconfirmapass";
            this.lbconfirmapass.Size = new System.Drawing.Size(160, 20);
            this.lbconfirmapass.TabIndex = 0;
            this.lbconfirmapass.Text = "Confirma Contraseña";
            // 
            // txtconpassword
            // 
            this.txtconpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconpassword.Location = new System.Drawing.Point(217, 146);
            this.txtconpassword.Name = "txtconpassword";
            this.txtconpassword.PasswordChar = '*';
            this.txtconpassword.Size = new System.Drawing.Size(145, 26);
            this.txtconpassword.TabIndex = 1;
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(51, 203);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(65, 20);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(217, 197);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(145, 26);
            this.txtnombre.TabIndex = 1;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(163, 252);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(113, 36);
            this.btnregistrar.TabIndex = 2;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarsesion.Location = new System.Drawing.Point(163, 294);
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Size = new System.Drawing.Size(123, 39);
            this.btniniciarsesion.TabIndex = 3;
            this.btniniciarsesion.Text = "Iniciar Sesion";
            this.btniniciarsesion.UseVisualStyleBackColor = true;
            this.btniniciarsesion.Click += new System.EventHandler(this.btniniciarsesion_Click);
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 345);
            this.Controls.Add(this.btniniciarsesion);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtconpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lbconfirmapass);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbusuario);
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lbconfirmapass;
        private System.Windows.Forms.TextBox txtconpassword;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btniniciarsesion;
    }
}

