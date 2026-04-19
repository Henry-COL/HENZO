namespace GeoIntegral.Views
{
    partial class Load_Screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load_Screen));
            this.Logo_App = new System.Windows.Forms.PictureBox();
            this.tmrFadeIn = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Barra_Carga = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.txtUsuario_Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContraseña_Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_App)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo_App
            // 
            this.Logo_App.Enabled = false;
            this.Logo_App.Image = ((System.Drawing.Image)(resources.GetObject("Logo_App.Image")));
            this.Logo_App.Location = new System.Drawing.Point(116, -34);
            this.Logo_App.Name = "Logo_App";
            this.Logo_App.Size = new System.Drawing.Size(754, 376);
            this.Logo_App.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_App.TabIndex = 0;
            this.Logo_App.TabStop = false;
            // 
            // tmrFadeIn
            // 
            this.tmrFadeIn.Enabled = true;
            this.tmrFadeIn.Tick += new System.EventHandler(this.tmrFadeIn_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(915, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 14;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Barra_Carga
            // 
            this.Barra_Carga.BorderRadius = 6;
            this.Barra_Carga.Location = new System.Drawing.Point(65, 28);
            this.Barra_Carga.Name = "Barra_Carga";
            this.Barra_Carga.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Barra_Carga.ProgressColor2 = System.Drawing.Color.Green;
            this.Barra_Carga.Size = new System.Drawing.Size(823, 30);
            this.Barra_Carga.TabIndex = 5;
            this.Barra_Carga.Text = "guna2ProgressBar1";
            this.Barra_Carga.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // txtUsuario_Login
            // 
            this.txtUsuario_Login.BorderColor = System.Drawing.Color.Black;
            this.txtUsuario_Login.BorderRadius = 7;
            this.txtUsuario_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario_Login.DefaultText = "";
            this.txtUsuario_Login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario_Login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario_Login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario_Login.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario_Login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario_Login.Location = new System.Drawing.Point(70, 48);
            this.txtUsuario_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario_Login.Name = "txtUsuario_Login";
            this.txtUsuario_Login.PlaceholderText = "Ingrese su nombre de usuaro.";
            this.txtUsuario_Login.SelectedText = "";
            this.txtUsuario_Login.Size = new System.Drawing.Size(305, 33);
            this.txtUsuario_Login.TabIndex = 7;
            this.txtUsuario_Login.TextChanged += new System.EventHandler(this.txtUsuario_Login_TextChanged);
            // 
            // txtContraseña_Login
            // 
            this.txtContraseña_Login.BorderColor = System.Drawing.Color.Black;
            this.txtContraseña_Login.BorderRadius = 7;
            this.txtContraseña_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña_Login.DefaultText = "";
            this.txtContraseña_Login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContraseña_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContraseña_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseña_Login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseña_Login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseña_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContraseña_Login.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña_Login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseña_Login.Location = new System.Drawing.Point(70, 113);
            this.txtContraseña_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña_Login.Name = "txtContraseña_Login";
            this.txtContraseña_Login.PlaceholderText = "Ingrese su contraseña.";
            this.txtContraseña_Login.SelectedText = "";
            this.txtContraseña_Login.Size = new System.Drawing.Size(305, 33);
            this.txtContraseña_Login.TabIndex = 8;
            this.txtContraseña_Login.TextChanged += new System.EventHandler(this.txtContraseña_Login_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(103, 165);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(234, 45);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Iniciar Sesión";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(23, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Recuperar Contraseña.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(226, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Registrarme en la App.";
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje1.ForeColor = System.Drawing.Color.Brown;
            this.lblMensaje1.Location = new System.Drawing.Point(214, 23);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(161, 20);
            this.lblMensaje1.TabIndex = 14;
            this.lblMensaje1.Text = "Campo obligatorio*";
            this.lblMensaje1.Visible = false;
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje2.ForeColor = System.Drawing.Color.Brown;
            this.lblMensaje2.Location = new System.Drawing.Point(214, 89);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(161, 20);
            this.lblMensaje2.TabIndex = 15;
            this.lblMensaje2.Text = "Campo obligatorio*";
            this.lblMensaje2.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Panel1.BorderRadius = 14;
            this.guna2Panel1.Controls.Add(this.lblMensaje1);
            this.guna2Panel1.Controls.Add(this.lblMensaje2);
            this.guna2Panel1.Controls.Add(this.txtUsuario_Login);
            this.guna2Panel1.Controls.Add(this.txtContraseña_Login);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(312, 245);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(412, 262);
            this.guna2Panel1.TabIndex = 16;
            // 
            // Load_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 556);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Barra_Carga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logo_App);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeoIntegral";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_App)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_App;
        private System.Windows.Forms.Timer tmrFadeIn;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ProgressBar Barra_Carga;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña_Login;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario_Login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.Label lblMensaje1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}