namespace ReproductorMusica
{
    partial class Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.Music_Image = new System.Windows.Forms.PictureBox();
            this.Wallpaper = new System.Windows.Forms.PictureBox();
            this.Titulo_Musica = new System.Windows.Forms.Label();
            this.BarraProgreso = new System.Windows.Forms.ProgressBar();
            this.TiempoTranscurrido = new System.Windows.Forms.Label();
            this.TiempoTotal = new System.Windows.Forms.Label();
            this.Reproducir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Music_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // Music_Image
            // 
            this.Music_Image.BackColor = System.Drawing.Color.Black;
            this.Music_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Music_Image.Image = ((System.Drawing.Image)(resources.GetObject("Music_Image.Image")));
            this.Music_Image.Location = new System.Drawing.Point(223, 68);
            this.Music_Image.Name = "Music_Image";
            this.Music_Image.Size = new System.Drawing.Size(366, 369);
            this.Music_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Music_Image.TabIndex = 0;
            this.Music_Image.TabStop = false;
            // 
            // Wallpaper
            // 
            this.Wallpaper.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Wallpaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wallpaper.Location = new System.Drawing.Point(24, 27);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.Size = new System.Drawing.Size(767, 632);
            this.Wallpaper.TabIndex = 1;
            this.Wallpaper.TabStop = false;
            // 
            // Titulo_Musica
            // 
            this.Titulo_Musica.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Titulo_Musica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo_Musica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Titulo_Musica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Musica.Location = new System.Drawing.Point(149, 454);
            this.Titulo_Musica.Name = "Titulo_Musica";
            this.Titulo_Musica.Size = new System.Drawing.Size(518, 30);
            this.Titulo_Musica.TabIndex = 2;
            this.Titulo_Musica.Text = "Titulo de la música";
            this.Titulo_Musica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarraProgreso
            // 
            this.BarraProgreso.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BarraProgreso.Location = new System.Drawing.Point(200, 519);
            this.BarraProgreso.Name = "BarraProgreso";
            this.BarraProgreso.Size = new System.Drawing.Size(430, 20);
            this.BarraProgreso.TabIndex = 3;
            // 
            // TiempoTranscurrido
            // 
            this.TiempoTranscurrido.AutoSize = true;
            this.TiempoTranscurrido.Location = new System.Drawing.Point(131, 519);
            this.TiempoTranscurrido.Name = "TiempoTranscurrido";
            this.TiempoTranscurrido.Size = new System.Drawing.Size(40, 20);
            this.TiempoTranscurrido.TabIndex = 4;
            this.TiempoTranscurrido.Text = "0:00";
            // 
            // TiempoTotal
            // 
            this.TiempoTotal.AutoSize = true;
            this.TiempoTotal.Location = new System.Drawing.Point(656, 519);
            this.TiempoTotal.Name = "TiempoTotal";
            this.TiempoTotal.Size = new System.Drawing.Size(40, 20);
            this.TiempoTotal.TabIndex = 5;
            this.TiempoTotal.Text = "0:00";
            // 
            // Reproducir
            // 
            this.Reproducir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Reproducir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reproducir.BackgroundImage")));
            this.Reproducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Reproducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reproducir.Location = new System.Drawing.Point(384, 565);
            this.Reproducir.Name = "Reproducir";
            this.Reproducir.Size = new System.Drawing.Size(82, 61);
            this.Reproducir.TabIndex = 6;
            this.Reproducir.UseVisualStyleBackColor = false;
            this.Reproducir.Click += new System.EventHandler(this.Reproducir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 694);
            this.Controls.Add(this.Reproducir);
            this.Controls.Add(this.TiempoTotal);
            this.Controls.Add(this.TiempoTranscurrido);
            this.Controls.Add(this.BarraProgreso);
            this.Controls.Add(this.Titulo_Musica);
            this.Controls.Add(this.Music_Image);
            this.Controls.Add(this.Wallpaper);
            this.Name = "Reproductor";
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.Music_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Music_Image;
        private System.Windows.Forms.PictureBox Wallpaper;
        private System.Windows.Forms.Label Titulo_Musica;
        private System.Windows.Forms.ProgressBar BarraProgreso;
        private System.Windows.Forms.Label TiempoTranscurrido;
        private System.Windows.Forms.Label TiempoTotal;
        private System.Windows.Forms.Button Reproducir;
        private System.Windows.Forms.Timer timer1;
    }
}