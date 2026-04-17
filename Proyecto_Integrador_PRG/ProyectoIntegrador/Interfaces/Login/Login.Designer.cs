namespace ProyectoIntegrador
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUsuario_Login = new System.Windows.Forms.Label();
            this.lblContraseña_Login = new System.Windows.Forms.Label();
            this.txtUser_Login = new System.Windows.Forms.TextBox();
            this.txtContraseña_Login = new System.Windows.Forms.TextBox();
            this.lblMensaje_Usuario_Login = new System.Windows.Forms.Label();
            this.lblMensaje_Contraseña_Login = new System.Windows.Forms.Label();
            this.lblError_Usuario_Login = new System.Windows.Forms.Label();
            this.lblError_Contraseña_Login = new System.Windows.Forms.Label();
            this.lblOlvidoContraseña_Login = new System.Windows.Forms.Label();
            this.btnIniciarSesion_Login = new System.Windows.Forms.Button();
            this.lblRegistrarse_Login = new System.Windows.Forms.Label();
            this.picLogo_Login = new System.Windows.Forms.PictureBox();
            this.btnMostarContraseña_Login = new System.Windows.Forms.Button();
            this.btn_cerrar_login = new System.Windows.Forms.Button();
            this.btn_ventana_login = new System.Windows.Forms.Button();
            this.btn_minimizar_login = new System.Windows.Forms.Button();
            this.Fondo_Inicio = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo_Login)).BeginInit();
            this.Fondo_Inicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario_Login
            // 
            this.lblUsuario_Login.AutoSize = true;
            this.lblUsuario_Login.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario_Login.Location = new System.Drawing.Point(58, 273);
            this.lblUsuario_Login.Name = "lblUsuario_Login";
            this.lblUsuario_Login.Size = new System.Drawing.Size(85, 22);
            this.lblUsuario_Login.TabIndex = 3;
            this.lblUsuario_Login.Text = "Usuario:";
            // 
            // lblContraseña_Login
            // 
            this.lblContraseña_Login.AutoSize = true;
            this.lblContraseña_Login.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblContraseña_Login.Location = new System.Drawing.Point(58, 346);
            this.lblContraseña_Login.Name = "lblContraseña_Login";
            this.lblContraseña_Login.Size = new System.Drawing.Size(119, 22);
            this.lblContraseña_Login.TabIndex = 5;
            this.lblContraseña_Login.Text = "Contraseña:";
            // 
            // txtUser_Login
            // 
            this.txtUser_Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUser_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser_Login.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F, System.Drawing.FontStyle.Bold);
            this.txtUser_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUser_Login.Location = new System.Drawing.Point(62, 302);
            this.txtUser_Login.Name = "txtUser_Login";
            this.txtUser_Login.Size = new System.Drawing.Size(315, 29);
            this.txtUser_Login.TabIndex = 7;
            this.txtUser_Login.TextChanged += new System.EventHandler(this.txtUser_Login_TextChanged);
            this.txtUser_Login.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.txtUser_Login_HelpRequested);
            // 
            // txtContraseña_Login
            // 
            this.txtContraseña_Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtContraseña_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña_Login.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F, System.Drawing.FontStyle.Bold);
            this.txtContraseña_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtContraseña_Login.Location = new System.Drawing.Point(62, 374);
            this.txtContraseña_Login.MaxLength = 8;
            this.txtContraseña_Login.Name = "txtContraseña_Login";
            this.txtContraseña_Login.Size = new System.Drawing.Size(315, 29);
            this.txtContraseña_Login.TabIndex = 8;
            this.txtContraseña_Login.TextChanged += new System.EventHandler(this.txtContraseña_Login_TextChanged);
            // 
            // lblMensaje_Usuario_Login
            // 
            this.lblMensaje_Usuario_Login.AutoSize = true;
            this.lblMensaje_Usuario_Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMensaje_Usuario_Login.CausesValidation = false;
            this.lblMensaje_Usuario_Login.Enabled = false;
            this.lblMensaje_Usuario_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensaje_Usuario_Login.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMensaje_Usuario_Login.Location = new System.Drawing.Point(71, 306);
            this.lblMensaje_Usuario_Login.Name = "lblMensaje_Usuario_Login";
            this.lblMensaje_Usuario_Login.Size = new System.Drawing.Size(219, 20);
            this.lblMensaje_Usuario_Login.TabIndex = 9;
            this.lblMensaje_Usuario_Login.Text = "Ingrese el nombre de usuario.";
            this.lblMensaje_Usuario_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensaje_Usuario_Login.Click += new System.EventHandler(this.txtUser_Login_TextChanged);
            // 
            // lblMensaje_Contraseña_Login
            // 
            this.lblMensaje_Contraseña_Login.AutoSize = true;
            this.lblMensaje_Contraseña_Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMensaje_Contraseña_Login.CausesValidation = false;
            this.lblMensaje_Contraseña_Login.Enabled = false;
            this.lblMensaje_Contraseña_Login.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMensaje_Contraseña_Login.Location = new System.Drawing.Point(71, 378);
            this.lblMensaje_Contraseña_Login.Name = "lblMensaje_Contraseña_Login";
            this.lblMensaje_Contraseña_Login.Size = new System.Drawing.Size(167, 20);
            this.lblMensaje_Contraseña_Login.TabIndex = 10;
            this.lblMensaje_Contraseña_Login.Text = "Ingrese la contraseña.";
            this.lblMensaje_Contraseña_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblError_Usuario_Login
            // 
            this.lblError_Usuario_Login.AutoSize = true;
            this.lblError_Usuario_Login.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Usuario_Login.CausesValidation = false;
            this.lblError_Usuario_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError_Usuario_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Usuario_Login.ForeColor = System.Drawing.Color.Orange;
            this.lblError_Usuario_Login.Location = new System.Drawing.Point(216, 276);
            this.lblError_Usuario_Login.Name = "lblError_Usuario_Login";
            this.lblError_Usuario_Login.Size = new System.Drawing.Size(161, 20);
            this.lblError_Usuario_Login.TabIndex = 11;
            this.lblError_Usuario_Login.Text = "Campo obligatorio*";
            this.lblError_Usuario_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError_Usuario_Login.Visible = false;
            // 
            // lblError_Contraseña_Login
            // 
            this.lblError_Contraseña_Login.AutoSize = true;
            this.lblError_Contraseña_Login.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Contraseña_Login.CausesValidation = false;
            this.lblError_Contraseña_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError_Contraseña_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Contraseña_Login.ForeColor = System.Drawing.Color.Orange;
            this.lblError_Contraseña_Login.Location = new System.Drawing.Point(216, 349);
            this.lblError_Contraseña_Login.Name = "lblError_Contraseña_Login";
            this.lblError_Contraseña_Login.Size = new System.Drawing.Size(161, 20);
            this.lblError_Contraseña_Login.TabIndex = 12;
            this.lblError_Contraseña_Login.Text = "Campo obligatorio*";
            this.lblError_Contraseña_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError_Contraseña_Login.Visible = false;
            // 
            // lblOlvidoContraseña_Login
            // 
            this.lblOlvidoContraseña_Login.AutoSize = true;
            this.lblOlvidoContraseña_Login.BackColor = System.Drawing.Color.Transparent;
            this.lblOlvidoContraseña_Login.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblOlvidoContraseña_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidoContraseña_Login.ForeColor = System.Drawing.SystemColors.Info;
            this.lblOlvidoContraseña_Login.Location = new System.Drawing.Point(30, 505);
            this.lblOlvidoContraseña_Login.Name = "lblOlvidoContraseña_Login";
            this.lblOlvidoContraseña_Login.Size = new System.Drawing.Size(175, 20);
            this.lblOlvidoContraseña_Login.TabIndex = 13;
            this.lblOlvidoContraseña_Login.Text = "¿Olvidó su contraseña?";
            this.lblOlvidoContraseña_Login.Click += new System.EventHandler(this.lblOlvidoContraseña_Login_Click);
            // 
            // btnIniciarSesion_Login
            // 
            this.btnIniciarSesion_Login.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIniciarSesion_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIniciarSesion_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion_Login.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSesion_Login.Location = new System.Drawing.Point(108, 436);
            this.btnIniciarSesion_Login.Name = "btnIniciarSesion_Login";
            this.btnIniciarSesion_Login.Size = new System.Drawing.Size(198, 39);
            this.btnIniciarSesion_Login.TabIndex = 14;
            this.btnIniciarSesion_Login.Text = "Iniciar Sesión";
            this.btnIniciarSesion_Login.UseVisualStyleBackColor = false;
            this.btnIniciarSesion_Login.Click += new System.EventHandler(this.btnIniciarSesion_Login_Click);
            // 
            // lblRegistrarse_Login
            // 
            this.lblRegistrarse_Login.AutoSize = true;
            this.lblRegistrarse_Login.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarse_Login.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblRegistrarse_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse_Login.ForeColor = System.Drawing.SystemColors.Info;
            this.lblRegistrarse_Login.Location = new System.Drawing.Point(232, 505);
            this.lblRegistrarse_Login.Name = "lblRegistrarse_Login";
            this.lblRegistrarse_Login.Size = new System.Drawing.Size(151, 20);
            this.lblRegistrarse_Login.TabIndex = 15;
            this.lblRegistrarse_Login.Text = "Registrarse a la app";
            this.lblRegistrarse_Login.Click += new System.EventHandler(this.lblRegistrarse_Login_Click);
            // 
            // picLogo_Login
            // 
            this.picLogo_Login.Location = new System.Drawing.Point(86, 22);
            this.picLogo_Login.Name = "picLogo_Login";
            this.picLogo_Login.Size = new System.Drawing.Size(257, 235);
            this.picLogo_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo_Login.TabIndex = 16;
            this.picLogo_Login.TabStop = false;
            // 
            // btnMostarContraseña_Login
            // 
            this.btnMostarContraseña_Login.Location = new System.Drawing.Point(340, 374);
            this.btnMostarContraseña_Login.Name = "btnMostarContraseña_Login";
            this.btnMostarContraseña_Login.Size = new System.Drawing.Size(37, 29);
            this.btnMostarContraseña_Login.TabIndex = 17;
            this.btnMostarContraseña_Login.Text = "(+)";
            this.btnMostarContraseña_Login.UseVisualStyleBackColor = true;
            this.btnMostarContraseña_Login.Click += new System.EventHandler(this.btnMostarContraseña_Login_Click);
            // 
            // btn_cerrar_login
            // 
            this.btn_cerrar_login.BackColor = System.Drawing.Color.Black;
            this.btn_cerrar_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_login.BackgroundImage")));
            this.btn_cerrar_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar_login.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_cerrar_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_login.Location = new System.Drawing.Point(965, 15);
            this.btn_cerrar_login.Name = "btn_cerrar_login";
            this.btn_cerrar_login.Size = new System.Drawing.Size(53, 32);
            this.btn_cerrar_login.TabIndex = 20;
            this.btn_cerrar_login.UseVisualStyleBackColor = false;
            this.btn_cerrar_login.Click += new System.EventHandler(this.btnCerrrar_Login_Click);
            // 
            // btn_ventana_login
            // 
            this.btn_ventana_login.BackColor = System.Drawing.Color.Black;
            this.btn_ventana_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ventana_login.BackgroundImage")));
            this.btn_ventana_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ventana_login.FlatAppearance.BorderSize = 0;
            this.btn_ventana_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_ventana_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventana_login.Location = new System.Drawing.Point(906, 15);
            this.btn_ventana_login.Name = "btn_ventana_login";
            this.btn_ventana_login.Size = new System.Drawing.Size(53, 32);
            this.btn_ventana_login.TabIndex = 21;
            this.btn_ventana_login.UseVisualStyleBackColor = false;
            this.btn_ventana_login.Click += new System.EventHandler(this.btn_ventana_login_Click);
            // 
            // btn_minimizar_login
            // 
            this.btn_minimizar_login.BackColor = System.Drawing.Color.Black;
            this.btn_minimizar_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimizar_login.BackgroundImage")));
            this.btn_minimizar_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimizar_login.FlatAppearance.BorderSize = 0;
            this.btn_minimizar_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_minimizar_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar_login.Location = new System.Drawing.Point(847, 15);
            this.btn_minimizar_login.Name = "btn_minimizar_login";
            this.btn_minimizar_login.Size = new System.Drawing.Size(53, 32);
            this.btn_minimizar_login.TabIndex = 22;
            this.btn_minimizar_login.UseVisualStyleBackColor = false;
            this.btn_minimizar_login.Click += new System.EventHandler(this.btn_minimizar_login_Click);
            // 
            // Fondo_Inicio
            // 
            this.Fondo_Inicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fondo_Inicio.BackgroundImage")));
            this.Fondo_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fondo_Inicio.Controls.Add(this.picLogo_Login);
            this.Fondo_Inicio.Controls.Add(this.lblError_Usuario_Login);
            this.Fondo_Inicio.Controls.Add(this.lblUsuario_Login);
            this.Fondo_Inicio.Controls.Add(this.lblContraseña_Login);
            this.Fondo_Inicio.Controls.Add(this.btnMostarContraseña_Login);
            this.Fondo_Inicio.Controls.Add(this.lblMensaje_Usuario_Login);
            this.Fondo_Inicio.Controls.Add(this.lblMensaje_Contraseña_Login);
            this.Fondo_Inicio.Controls.Add(this.lblRegistrarse_Login);
            this.Fondo_Inicio.Controls.Add(this.lblError_Contraseña_Login);
            this.Fondo_Inicio.Controls.Add(this.btnIniciarSesion_Login);
            this.Fondo_Inicio.Controls.Add(this.lblOlvidoContraseña_Login);
            this.Fondo_Inicio.Controls.Add(this.txtUser_Login);
            this.Fondo_Inicio.Controls.Add(this.txtContraseña_Login);
            this.Fondo_Inicio.Location = new System.Drawing.Point(296, 110);
            this.Fondo_Inicio.Name = "Fondo_Inicio";
            this.Fondo_Inicio.Size = new System.Drawing.Size(408, 541);
            this.Fondo_Inicio.TabIndex = 23;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 733);
            this.Controls.Add(this.Fondo_Inicio);
            this.Controls.Add(this.btn_minimizar_login);
            this.Controls.Add(this.btn_ventana_login);
            this.Controls.Add(this.btn_cerrar_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo_Login)).EndInit();
            this.Fondo_Inicio.ResumeLayout(false);
            this.Fondo_Inicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario_Login;
        private System.Windows.Forms.Label lblContraseña_Login;
        private System.Windows.Forms.TextBox txtUser_Login;
        private System.Windows.Forms.TextBox txtContraseña_Login;
        private System.Windows.Forms.Label lblMensaje_Usuario_Login;
        private System.Windows.Forms.Label lblMensaje_Contraseña_Login;
        private System.Windows.Forms.Label lblError_Usuario_Login;
        private System.Windows.Forms.Label lblError_Contraseña_Login;
        private System.Windows.Forms.Label lblOlvidoContraseña_Login;
        private System.Windows.Forms.Button btnIniciarSesion_Login;
        private System.Windows.Forms.Label lblRegistrarse_Login;
        private System.Windows.Forms.PictureBox picLogo_Login;
        private System.Windows.Forms.Button btnMostarContraseña_Login;
        private System.Windows.Forms.Button btn_cerrar_login;
        private System.Windows.Forms.Button btn_ventana_login;
        private System.Windows.Forms.Button btn_minimizar_login;
        private System.Windows.Forms.Panel Fondo_Inicio;
    }
}