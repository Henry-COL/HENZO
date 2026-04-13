namespace PWV_Ejercicio_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre_box = new System.Windows.Forms.TextBox();
            this.Apellido_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.NumeroHabitaciones = new System.Windows.Forms.NumericUpDown();
            this.Cantidad_Personas = new System.Windows.Forms.NumericUpDown();
            this.TipoVehiculo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mensaje_Nombre = new System.Windows.Forms.Label();
            this.Mensaje_Apellido = new System.Windows.Forms.Label();
            this.Mensaje_ID = new System.Windows.Forms.Label();
            this.Mensaje_TipoVehiculo = new System.Windows.Forms.Label();
            this.Mensaje_Fecha1 = new System.Windows.Forms.Label();
            this.Mensaje_Fecha2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Boton_Registrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_Personas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("00279", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL: TRAVESAÑO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("00279", 9F);
            this.label2.Location = new System.Drawing.Point(101, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Nombre_box
            // 
            this.Nombre_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nombre_box.Location = new System.Drawing.Point(257, 218);
            this.Nombre_box.Name = "Nombre_box";
            this.Nombre_box.Size = new System.Drawing.Size(169, 26);
            this.Nombre_box.TabIndex = 2;
            this.Nombre_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Apellido_box
            // 
            this.Apellido_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Apellido_box.Location = new System.Drawing.Point(257, 260);
            this.Apellido_box.Name = "Apellido_box";
            this.Apellido_box.Size = new System.Drawing.Size(169, 26);
            this.Apellido_box.TabIndex = 4;
            this.Apellido_box.TextChanged += new System.EventHandler(this.Apellido_box_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("00279", 9F);
            this.label3.Location = new System.Drawing.Point(100, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID_box
            // 
            this.ID_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_box.Location = new System.Drawing.Point(257, 300);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(169, 26);
            this.ID_box.TabIndex = 6;
            this.ID_box.TextChanged += new System.EventHandler(this.ID_box_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("00279", 9F);
            this.label4.Location = new System.Drawing.Point(100, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cédula:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("00279", 9F);
            this.label5.Location = new System.Drawing.Point(100, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Personas:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("00279", 9F);
            this.label6.Location = new System.Drawing.Point(101, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vehículo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("00279", 9F);
            this.label7.Location = new System.Drawing.Point(100, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Habitaciones:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FechaInicio
            // 
            this.FechaInicio.Font = new System.Drawing.Font("00279", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicio.Location = new System.Drawing.Point(257, 479);
            this.FechaInicio.MaxDate = new System.DateTime(2026, 8, 12, 0, 0, 0, 0);
            this.FechaInicio.MinDate = new System.DateTime(2026, 4, 12, 22, 31, 58, 0);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FechaInicio.Size = new System.Drawing.Size(169, 27);
            this.FechaInicio.TabIndex = 13;
            this.FechaInicio.Value = new System.DateTime(2026, 4, 12, 22, 31, 58, 0);
            this.FechaInicio.ValueChanged += new System.EventHandler(this.FechaInicio_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("00279", 9F);
            this.label8.Location = new System.Drawing.Point(101, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha Inicio:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("00279", 9F);
            this.label9.Location = new System.Drawing.Point(100, 533);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha Final:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FechaFinal
            // 
            this.FechaFinal.Font = new System.Drawing.Font("00279", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFinal.Location = new System.Drawing.Point(257, 533);
            this.FechaFinal.MaxDate = new System.DateTime(2026, 8, 12, 0, 0, 0, 0);
            this.FechaFinal.MinDate = new System.DateTime(2026, 4, 12, 22, 31, 58, 0);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FechaFinal.Size = new System.Drawing.Size(169, 27);
            this.FechaFinal.TabIndex = 15;
            this.FechaFinal.Value = new System.DateTime(2026, 4, 12, 22, 31, 58, 0);
            this.FechaFinal.ValueChanged += new System.EventHandler(this.FechaFinal_ValueChanged);
            // 
            // NumeroHabitaciones
            // 
            this.NumeroHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumeroHabitaciones.Location = new System.Drawing.Point(257, 430);
            this.NumeroHabitaciones.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumeroHabitaciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumeroHabitaciones.Name = "NumeroHabitaciones";
            this.NumeroHabitaciones.Size = new System.Drawing.Size(169, 26);
            this.NumeroHabitaciones.TabIndex = 17;
            this.NumeroHabitaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumeroHabitaciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cantidad_Personas
            // 
            this.Cantidad_Personas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cantidad_Personas.Location = new System.Drawing.Point(257, 342);
            this.Cantidad_Personas.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Cantidad_Personas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cantidad_Personas.Name = "Cantidad_Personas";
            this.Cantidad_Personas.Size = new System.Drawing.Size(169, 26);
            this.Cantidad_Personas.TabIndex = 18;
            this.Cantidad_Personas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cantidad_Personas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cantidad_Personas.ValueChanged += new System.EventHandler(this.Cantidad_Personas_ValueChanged);
            // 
            // TipoVehiculo
            // 
            this.TipoVehiculo.CausesValidation = false;
            this.TipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoVehiculo.FormattingEnabled = true;
            this.TipoVehiculo.Items.AddRange(new object[] {
            "Ninguno",
            "Carro",
            "Moto",
            "Camioneta"});
            this.TipoVehiculo.Location = new System.Drawing.Point(257, 385);
            this.TipoVehiculo.Name = "TipoVehiculo";
            this.TipoVehiculo.Size = new System.Drawing.Size(169, 28);
            this.TipoVehiculo.TabIndex = 19;
            this.TipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.TipoVehiculo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(66, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(907, 549);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Mensaje_Nombre
            // 
            this.Mensaje_Nombre.AutoSize = true;
            this.Mensaje_Nombre.BackColor = System.Drawing.SystemColors.Info;
            this.Mensaje_Nombre.ForeColor = System.Drawing.Color.DarkRed;
            this.Mensaje_Nombre.Location = new System.Drawing.Point(436, 222);
            this.Mensaje_Nombre.Name = "Mensaje_Nombre";
            this.Mensaje_Nombre.Size = new System.Drawing.Size(161, 20);
            this.Mensaje_Nombre.TabIndex = 21;
            this.Mensaje_Nombre.Text = "Se solicita el Nombre.";
            this.Mensaje_Nombre.Visible = false;
            // 
            // Mensaje_Apellido
            // 
            this.Mensaje_Apellido.AutoSize = true;
            this.Mensaje_Apellido.BackColor = System.Drawing.SystemColors.Info;
            this.Mensaje_Apellido.ForeColor = System.Drawing.Color.DarkRed;
            this.Mensaje_Apellido.Location = new System.Drawing.Point(436, 262);
            this.Mensaje_Apellido.Name = "Mensaje_Apellido";
            this.Mensaje_Apellido.Size = new System.Drawing.Size(161, 20);
            this.Mensaje_Apellido.TabIndex = 22;
            this.Mensaje_Apellido.Text = "Se solicita el Apellido.";
            this.Mensaje_Apellido.Visible = false;
            // 
            // Mensaje_ID
            // 
            this.Mensaje_ID.AutoSize = true;
            this.Mensaje_ID.BackColor = System.Drawing.SystemColors.Info;
            this.Mensaje_ID.ForeColor = System.Drawing.Color.DarkRed;
            this.Mensaje_ID.Location = new System.Drawing.Point(436, 300);
            this.Mensaje_ID.Name = "Mensaje_ID";
            this.Mensaje_ID.Size = new System.Drawing.Size(122, 20);
            this.Mensaje_ID.TabIndex = 23;
            this.Mensaje_ID.Text = "Se solicita el ID.";
            this.Mensaje_ID.Visible = false;
            // 
            // Mensaje_TipoVehiculo
            // 
            this.Mensaje_TipoVehiculo.AutoSize = true;
            this.Mensaje_TipoVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.Mensaje_TipoVehiculo.ForeColor = System.Drawing.Color.DarkRed;
            this.Mensaje_TipoVehiculo.Location = new System.Drawing.Point(436, 388);
            this.Mensaje_TipoVehiculo.Name = "Mensaje_TipoVehiculo";
            this.Mensaje_TipoVehiculo.Size = new System.Drawing.Size(104, 20);
            this.Mensaje_TipoVehiculo.TabIndex = 24;
            this.Mensaje_TipoVehiculo.Text = "Selecciona 1.";
            this.Mensaje_TipoVehiculo.Visible = false;
            // 
            // Mensaje_Fecha1
            // 
            this.Mensaje_Fecha1.AutoSize = true;
            this.Mensaje_Fecha1.BackColor = System.Drawing.SystemColors.Info;
            this.Mensaje_Fecha1.ForeColor = System.Drawing.Color.DarkRed;
            this.Mensaje_Fecha1.Location = new System.Drawing.Point(436, 483);
            this.Mensaje_Fecha1.Name = "Mensaje_Fecha1";
            this.Mensaje_Fecha1.Size = new System.Drawing.Size(114, 20);
            this.Mensaje_Fecha1.TabIndex = 25;
            this.Mensaje_Fecha1.Text = "Fecha invalida.";
            this.Mensaje_Fecha1.Visible = false;
            // 
            // Mensaje_Fecha2
            // 
            this.Mensaje_Fecha2.AutoSize = true;
            this.Mensaje_Fecha2.BackColor = System.Drawing.SystemColors.Info;
            this.Mensaje_Fecha2.ForeColor = System.Drawing.Color.DarkRed;
            this.Mensaje_Fecha2.Location = new System.Drawing.Point(436, 538);
            this.Mensaje_Fecha2.Name = "Mensaje_Fecha2";
            this.Mensaje_Fecha2.Size = new System.Drawing.Size(114, 20);
            this.Mensaje_Fecha2.TabIndex = 26;
            this.Mensaje_Fecha2.Text = "Fecha invalida.";
            this.Mensaje_Fecha2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(641, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 334);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Boton_Registrar
            // 
            this.Boton_Registrar.BackColor = System.Drawing.Color.Tomato;
            this.Boton_Registrar.Font = new System.Drawing.Font("00279", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Registrar.Location = new System.Drawing.Point(422, 597);
            this.Boton_Registrar.Name = "Boton_Registrar";
            this.Boton_Registrar.Size = new System.Drawing.Size(175, 43);
            this.Boton_Registrar.TabIndex = 28;
            this.Boton_Registrar.Text = "Registrar";
            this.Boton_Registrar.UseVisualStyleBackColor = false;
            this.Boton_Registrar.Click += new System.EventHandler(this.Boton_Registrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 708);
            this.Controls.Add(this.Boton_Registrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Mensaje_Fecha2);
            this.Controls.Add(this.Mensaje_Fecha1);
            this.Controls.Add(this.Mensaje_TipoVehiculo);
            this.Controls.Add(this.Mensaje_ID);
            this.Controls.Add(this.Mensaje_Apellido);
            this.Controls.Add(this.Mensaje_Nombre);
            this.Controls.Add(this.TipoVehiculo);
            this.Controls.Add(this.Cantidad_Personas);
            this.Controls.Add(this.NumeroHabitaciones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FechaFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FechaInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Apellido_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumeroHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_Personas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre_box;
        private System.Windows.Forms.TextBox Apellido_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker FechaFinal;
        private System.Windows.Forms.NumericUpDown NumeroHabitaciones;
        private System.Windows.Forms.NumericUpDown Cantidad_Personas;
        private System.Windows.Forms.ComboBox TipoVehiculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Mensaje_Nombre;
        private System.Windows.Forms.Label Mensaje_Apellido;
        private System.Windows.Forms.Label Mensaje_ID;
        private System.Windows.Forms.Label Mensaje_TipoVehiculo;
        private System.Windows.Forms.Label Mensaje_Fecha1;
        private System.Windows.Forms.Label Mensaje_Fecha2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Boton_Registrar;
    }
}