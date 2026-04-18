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
            this.Barra_Carga = new System.Windows.Forms.ProgressBar();
            this.Mensaje_Carga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_App)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo_App
            // 
            this.Logo_App.Image = ((System.Drawing.Image)(resources.GetObject("Logo_App.Image")));
            this.Logo_App.Location = new System.Drawing.Point(121, 70);
            this.Logo_App.Name = "Logo_App";
            this.Logo_App.Size = new System.Drawing.Size(754, 376);
            this.Logo_App.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_App.TabIndex = 0;
            this.Logo_App.TabStop = false;
            // 
            // tmrFadeIn
            // 
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
            // Barra_Carga
            // 
            this.Barra_Carga.Location = new System.Drawing.Point(79, 435);
            this.Barra_Carga.Name = "Barra_Carga";
            this.Barra_Carga.Size = new System.Drawing.Size(823, 24);
            this.Barra_Carga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Barra_Carga.TabIndex = 2;
            // 
            // Mensaje_Carga
            // 
            this.Mensaje_Carga.AutoSize = true;
            this.Mensaje_Carga.Font = new System.Drawing.Font("Cambria Math", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensaje_Carga.Location = new System.Drawing.Point(364, 370);
            this.Mensaje_Carga.Name = "Mensaje_Carga";
            this.Mensaje_Carga.Size = new System.Drawing.Size(248, 89);
            this.Mensaje_Carga.TabIndex = 3;
            this.Mensaje_Carga.Text = "Cargando interfaces de inicio...";
            // 
            // Load_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 556);
            this.Controls.Add(this.Barra_Carga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mensaje_Carga);
            this.Controls.Add(this.Logo_App);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeoIntegral";
            this.Load += new System.EventHandler(this.Load_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_App)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_App;
        private System.Windows.Forms.Timer tmrFadeIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar Barra_Carga;
        private System.Windows.Forms.Label Mensaje_Carga;
    }
}