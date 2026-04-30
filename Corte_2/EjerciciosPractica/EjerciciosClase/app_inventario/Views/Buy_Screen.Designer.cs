namespace app_inventario.Views
{
    partial class Buy_Screen
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitulo_buy = new System.Windows.Forms.Label();
            this.lblPrecio_Buy = new System.Windows.Forms.Label();
            this.btnBuy_Comprar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuy_Cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 14;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.btnBuy_Cancelar);
            this.guna2Panel1.Controls.Add(this.btnBuy_Comprar);
            this.guna2Panel1.Controls.Add(this.lblPrecio_Buy);
            this.guna2Panel1.Controls.Add(this.lblTitulo_buy);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.guna2Panel1.Location = new System.Drawing.Point(20, 15);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(437, 640);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 7;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(44, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(343, 393);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblTitulo_buy
            // 
            this.lblTitulo_buy.AutoSize = true;
            this.lblTitulo_buy.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo_buy.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_buy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo_buy.Location = new System.Drawing.Point(3, 432);
            this.lblTitulo_buy.Name = "lblTitulo_buy";
            this.lblTitulo_buy.Size = new System.Drawing.Size(294, 43);
            this.lblTitulo_buy.TabIndex = 10;
            this.lblTitulo_buy.Text = "Titulo de la música";
            this.lblTitulo_buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio_Buy
            // 
            this.lblPrecio_Buy.AutoSize = true;
            this.lblPrecio_Buy.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio_Buy.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio_Buy.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblPrecio_Buy.Location = new System.Drawing.Point(13, 475);
            this.lblPrecio_Buy.Name = "lblPrecio_Buy";
            this.lblPrecio_Buy.Size = new System.Drawing.Size(62, 43);
            this.lblPrecio_Buy.TabIndex = 11;
            this.lblPrecio_Buy.Text = "$ 0";
            this.lblPrecio_Buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuy_Comprar
            // 
            this.btnBuy_Comprar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy_Comprar.BorderRadius = 7;
            this.btnBuy_Comprar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy_Comprar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy_Comprar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuy_Comprar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuy_Comprar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuy_Comprar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuy_Comprar.ForeColor = System.Drawing.Color.White;
            this.btnBuy_Comprar.Location = new System.Drawing.Point(207, 557);
            this.btnBuy_Comprar.Name = "btnBuy_Comprar";
            this.btnBuy_Comprar.Size = new System.Drawing.Size(180, 45);
            this.btnBuy_Comprar.TabIndex = 12;
            this.btnBuy_Comprar.Text = "Comprar";
            // 
            // btnBuy_Cancelar
            // 
            this.btnBuy_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy_Cancelar.BorderRadius = 7;
            this.btnBuy_Cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy_Cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy_Cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuy_Cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuy_Cancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuy_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuy_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btnBuy_Cancelar.Location = new System.Drawing.Point(21, 557);
            this.btnBuy_Cancelar.Name = "btnBuy_Cancelar";
            this.btnBuy_Cancelar.Size = new System.Drawing.Size(180, 45);
            this.btnBuy_Cancelar.TabIndex = 13;
            this.btnBuy_Cancelar.Text = "Cancelar Compra";
            this.btnBuy_Cancelar.Click += new System.EventHandler(this.btnBuy_Cancelar_Click);
            // 
            // Buy_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(479, 676);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buy_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy_Screen";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblTitulo_buy;
        private Guna.UI2.WinForms.Guna2Button btnBuy_Cancelar;
        private Guna.UI2.WinForms.Guna2Button btnBuy_Comprar;
        private System.Windows.Forms.Label lblPrecio_Buy;
    }
}