namespace PWV_Ejercicio_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Nombre_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mensaje_Registrar = new System.Windows.Forms.Label();
            this.Mensaje_Email = new System.Windows.Forms.Label();
            this.Mensaje_ID = new System.Windows.Forms.Label();
            this.Mensaje_Apellido = new System.Windows.Forms.Label();
            this.Mensaje_Nombre = new System.Windows.Forms.Label();
            this.Registrar_Boton = new System.Windows.Forms.Button();
            this.Email_box = new System.Windows.Forms.TextBox();
            this.Apellido_box = new System.Windows.Forms.TextBox();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Num = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tipo_Trabajo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mensaje_TipoTrabajo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Nombre_box
            // 
            this.Nombre_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nombre_box.Location = new System.Drawing.Point(92, 93);
            this.Nombre_box.Name = "Nombre_box";
            this.Nombre_box.Size = new System.Drawing.Size(197, 26);
            this.Nombre_box.TabIndex = 2;
            this.Nombre_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mensaje_TipoTrabajo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Tipo_Trabajo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Num);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.Mensaje_Registrar);
            this.groupBox1.Controls.Add(this.Mensaje_Email);
            this.groupBox1.Controls.Add(this.Mensaje_ID);
            this.groupBox1.Controls.Add(this.Mensaje_Apellido);
            this.groupBox1.Controls.Add(this.Mensaje_Nombre);
            this.groupBox1.Controls.Add(this.Registrar_Boton);
            this.groupBox1.Controls.Add(this.Email_box);
            this.groupBox1.Controls.Add(this.Apellido_box);
            this.groupBox1.Controls.Add(this.ID_box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Nombre_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(41, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 466);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema de Registro: Empleado";
            // 
            // Mensaje_Registrar
            // 
            this.Mensaje_Registrar.AutoSize = true;
            this.Mensaje_Registrar.ForeColor = System.Drawing.Color.DarkGreen;
            this.Mensaje_Registrar.Location = new System.Drawing.Point(313, 408);
            this.Mensaje_Registrar.Name = "Mensaje_Registrar";
            this.Mensaje_Registrar.Size = new System.Drawing.Size(334, 20);
            this.Mensaje_Registrar.TabIndex = 20;
            this.Mensaje_Registrar.Text = "¡El empleado ha sido registrado exitosamente!";
            this.Mensaje_Registrar.Visible = false;
            // 
            // Mensaje_Email
            // 
            this.Mensaje_Email.AutoSize = true;
            this.Mensaje_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mensaje_Email.Location = new System.Drawing.Point(351, 234);
            this.Mensaje_Email.Name = "Mensaje_Email";
            this.Mensaje_Email.Size = new System.Drawing.Size(162, 20);
            this.Mensaje_Email.TabIndex = 19;
            this.Mensaje_Email.Text = "El email es necesario.";
            this.Mensaje_Email.Visible = false;
            this.Mensaje_Email.Click += new System.EventHandler(this.label6_Click);
            // 
            // Mensaje_ID
            // 
            this.Mensaje_ID.AutoSize = true;
            this.Mensaje_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mensaje_ID.Location = new System.Drawing.Point(88, 234);
            this.Mensaje_ID.Name = "Mensaje_ID";
            this.Mensaje_ID.Size = new System.Drawing.Size(142, 20);
            this.Mensaje_ID.TabIndex = 18;
            this.Mensaje_ID.Text = "El ID es necesario.";
            this.Mensaje_ID.Visible = false;
            // 
            // Mensaje_Apellido
            // 
            this.Mensaje_Apellido.AutoSize = true;
            this.Mensaje_Apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mensaje_Apellido.Location = new System.Drawing.Point(351, 129);
            this.Mensaje_Apellido.Name = "Mensaje_Apellido";
            this.Mensaje_Apellido.Size = new System.Drawing.Size(179, 20);
            this.Mensaje_Apellido.TabIndex = 17;
            this.Mensaje_Apellido.Text = "El apellido es necesario.";
            this.Mensaje_Apellido.Visible = false;
            this.Mensaje_Apellido.Click += new System.EventHandler(this.Mensaje_Apellido_Click);
            // 
            // Mensaje_Nombre
            // 
            this.Mensaje_Nombre.AutoSize = true;
            this.Mensaje_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mensaje_Nombre.Location = new System.Drawing.Point(88, 129);
            this.Mensaje_Nombre.Name = "Mensaje_Nombre";
            this.Mensaje_Nombre.Size = new System.Drawing.Size(179, 20);
            this.Mensaje_Nombre.TabIndex = 16;
            this.Mensaje_Nombre.Text = "El nombre es necesario.";
            this.Mensaje_Nombre.Visible = false;
            this.Mensaje_Nombre.Click += new System.EventHandler(this.label5_Click);
            // 
            // Registrar_Boton
            // 
            this.Registrar_Boton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Registrar_Boton.Font = new System.Drawing.Font("00279", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar_Boton.Location = new System.Drawing.Point(355, 350);
            this.Registrar_Boton.Name = "Registrar_Boton";
            this.Registrar_Boton.Size = new System.Drawing.Size(241, 46);
            this.Registrar_Boton.TabIndex = 15;
            this.Registrar_Boton.Text = "Registrar Empleado";
            this.Registrar_Boton.UseVisualStyleBackColor = false;
            this.Registrar_Boton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Email_box
            // 
            this.Email_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email_box.Location = new System.Drawing.Point(355, 198);
            this.Email_box.Name = "Email_box";
            this.Email_box.Size = new System.Drawing.Size(196, 26);
            this.Email_box.TabIndex = 14;
            this.Email_box.TextChanged += new System.EventHandler(this.Email_box_TextChanged);
            // 
            // Apellido_box
            // 
            this.Apellido_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Apellido_box.Location = new System.Drawing.Point(355, 93);
            this.Apellido_box.Name = "Apellido_box";
            this.Apellido_box.Size = new System.Drawing.Size(197, 26);
            this.Apellido_box.TabIndex = 13;
            this.Apellido_box.TextChanged += new System.EventHandler(this.Apellido_box_TextChanged);
            // 
            // ID_box
            // 
            this.ID_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_box.Location = new System.Drawing.Point(92, 198);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(197, 26);
            this.ID_box.TabIndex = 12;
            this.ID_box.TextChanged += new System.EventHandler(this.ID_box_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Indentificación:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(740, 119);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(166, 30);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Tag = "";
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num.Location = new System.Drawing.Point(583, 120);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(144, 22);
            this.Num.TabIndex = 22;
            this.Num.Text = "Sueldo base: $";
            this.Num.Click += new System.EventHandler(this.Num_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tipo trabajo:";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // Tipo_Trabajo
            // 
            this.Tipo_Trabajo.CausesValidation = false;
            this.Tipo_Trabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo_Trabajo.FormattingEnabled = true;
            this.Tipo_Trabajo.Items.AddRange(new object[] {
            "Ventas",
            "IT",
            "Recursos Humanos",
            "Contabilidad"});
            this.Tipo_Trabajo.Location = new System.Drawing.Point(740, 183);
            this.Tipo_Trabajo.Name = "Tipo_Trabajo";
            this.Tipo_Trabajo.Size = new System.Drawing.Size(166, 28);
            this.Tipo_Trabajo.TabIndex = 24;
            this.Tipo_Trabajo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(722, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Mensaje_TipoTrabajo
            // 
            this.Mensaje_TipoTrabajo.AutoSize = true;
            this.Mensaje_TipoTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mensaje_TipoTrabajo.Location = new System.Drawing.Point(744, 223);
            this.Mensaje_TipoTrabajo.Name = "Mensaje_TipoTrabajo";
            this.Mensaje_TipoTrabajo.Size = new System.Drawing.Size(154, 20);
            this.Mensaje_TipoTrabajo.TabIndex = 26;
            this.Mensaje_TipoTrabajo.Text = "Rellena este campo.";
            this.Mensaje_TipoTrabajo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1007, 535);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox Nombre_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.Button Registrar_Boton;
        private System.Windows.Forms.TextBox Email_box;
        private System.Windows.Forms.TextBox Apellido_box;
        private System.Windows.Forms.Label Mensaje_Nombre;
        private System.Windows.Forms.Label Mensaje_Email;
        private System.Windows.Forms.Label Mensaje_ID;
        private System.Windows.Forms.Label Mensaje_Apellido;
        private System.Windows.Forms.Label Mensaje_Registrar;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox Tipo_Trabajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Mensaje_TipoTrabajo;
    }
}