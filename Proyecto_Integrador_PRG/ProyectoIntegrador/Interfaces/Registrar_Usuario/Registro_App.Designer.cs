namespace ProyectoIntegrador
{
    partial class Registro_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo_Registrar = new System.Windows.Forms.TextBox();
            this.txtCorreo_Confirmar_Registrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_RegistrarCuenta_Registrar = new System.Windows.Forms.Button();
            this.lblMensaje_Correo_Registrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número teléfonico:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(249, 92);
            this.maskedTextBox1.Mask = "(999)000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(143, 26);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Completo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo Electronico:";
            // 
            // txtCorreo_Registrar
            // 
            this.txtCorreo_Registrar.Location = new System.Drawing.Point(258, 130);
            this.txtCorreo_Registrar.Name = "txtCorreo_Registrar";
            this.txtCorreo_Registrar.Size = new System.Drawing.Size(173, 26);
            this.txtCorreo_Registrar.TabIndex = 5;
            // 
            // txtCorreo_Confirmar_Registrar
            // 
            this.txtCorreo_Confirmar_Registrar.Location = new System.Drawing.Point(258, 168);
            this.txtCorreo_Confirmar_Registrar.Name = "txtCorreo_Confirmar_Registrar";
            this.txtCorreo_Confirmar_Registrar.Size = new System.Drawing.Size(173, 26);
            this.txtCorreo_Confirmar_Registrar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar Electronico:";
            // 
            // btn_RegistrarCuenta_Registrar
            // 
            this.btn_RegistrarCuenta_Registrar.Location = new System.Drawing.Point(239, 237);
            this.btn_RegistrarCuenta_Registrar.Name = "btn_RegistrarCuenta_Registrar";
            this.btn_RegistrarCuenta_Registrar.Size = new System.Drawing.Size(202, 45);
            this.btn_RegistrarCuenta_Registrar.TabIndex = 8;
            this.btn_RegistrarCuenta_Registrar.Text = "Registrar Cuenta";
            this.btn_RegistrarCuenta_Registrar.UseVisualStyleBackColor = true;
            this.btn_RegistrarCuenta_Registrar.Click += new System.EventHandler(this.btn_RegistrarCuenta_Registrar_Click);
            // 
            // lblMensaje_Correo_Registrar
            // 
            this.lblMensaje_Correo_Registrar.AutoSize = true;
            this.lblMensaje_Correo_Registrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensaje_Correo_Registrar.Location = new System.Drawing.Point(437, 174);
            this.lblMensaje_Correo_Registrar.Name = "lblMensaje_Correo_Registrar";
            this.lblMensaje_Correo_Registrar.Size = new System.Drawing.Size(180, 20);
            this.lblMensaje_Correo_Registrar.TabIndex = 9;
            this.lblMensaje_Correo_Registrar.Text = "Los correos no coincide.";
            this.lblMensaje_Correo_Registrar.Visible = false;
            // 
            // Registro_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 684);
            this.Controls.Add(this.lblMensaje_Correo_Registrar);
            this.Controls.Add(this.btn_RegistrarCuenta_Registrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo_Confirmar_Registrar);
            this.Controls.Add(this.txtCorreo_Registrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Registro_App";
            this.Text = "Registro_App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo_Registrar;
        private System.Windows.Forms.TextBox txtCorreo_Confirmar_Registrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_RegistrarCuenta_Registrar;
        private System.Windows.Forms.Label lblMensaje_Correo_Registrar;
    }
}