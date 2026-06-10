namespace pryProyecto
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            pcbImagenLogin = new PictureBox();
            btnAcceder = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbImagenLogin).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(350, 123);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese el Usuario";
            txtUsuario.Size = new Size(279, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(350, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Ingrese la Contraseña";
            txtPassword.Size = new Size(279, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pcbImagenLogin
            // 
            pcbImagenLogin.Image = (Image)resources.GetObject("pcbImagenLogin.Image");
            pcbImagenLogin.Location = new Point(14, 84);
            pcbImagenLogin.Name = "pcbImagenLogin";
            pcbImagenLogin.Size = new Size(266, 236);
            pcbImagenLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagenLogin.TabIndex = 2;
            pcbImagenLogin.TabStop = false;
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(350, 277);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(102, 43);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(518, 277);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 43);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Controls.Add(pcbImagenLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pcbImagenLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPassword;
        private PictureBox pcbImagenLogin;
        private Button btnAcceder;
        private Button btnSalir;
    }
}
