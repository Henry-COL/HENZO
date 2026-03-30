namespace Ejercicio1_Clase
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
            this.GBoxPersonal = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBoxPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBoxPersonal
            // 
            this.GBoxPersonal.Controls.Add(this.label1);
            this.GBoxPersonal.Controls.Add(this.textBox1);
            this.GBoxPersonal.Location = new System.Drawing.Point(41, 34);
            this.GBoxPersonal.Name = "GBoxPersonal";
            this.GBoxPersonal.Size = new System.Drawing.Size(415, 322);
            this.GBoxPersonal.TabIndex = 0;
            this.GBoxPersonal.TabStop = false;
            this.GBoxPersonal.Text = "Informacion Personal";
            this.GBoxPersonal.Enter += new System.EventHandler(this.GBoxPersonal_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Ingrese su nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBoxPersonal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBoxPersonal.ResumeLayout(false);
            this.GBoxPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxPersonal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}