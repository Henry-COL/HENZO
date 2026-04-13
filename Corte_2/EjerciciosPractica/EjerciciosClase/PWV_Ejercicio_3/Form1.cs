using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWV_Ejercicio_3
{
    public partial class Form1 : Form
    {
        double precioBaseVehiculo = 0;
        double totalPagar = 0;

        public Form1()
        {
            InitializeComponent();
            FechaInicio.Value = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "¡Hola, Mundo!";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Mensaje_Nombre.Visible = (Nombre_box.Text == "");
        }

        private void Apellido_box_TextChanged(object sender, EventArgs e)
        {
            Mensaje_Apellido.Visible = (Apellido_box.Text == "");
        }

        private void ID_box_TextChanged(object sender, EventArgs e)
        {
            Mensaje_ID.Visible = (ID_box.Text == "");
        }

        private void Cantidad_Personas_ValueChanged(object sender, EventArgs e)
        {
            totalPagar = precioBaseVehiculo + (30000) + ((double)Cantidad_Personas.Value * 3000);
        }

        private void TipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoVehiculo.SelectedItem == null)
            {
                Mensaje_TipoVehiculo.Visible = true;
                return;
            }

            Mensaje_TipoVehiculo.Visible = false;
            string seleccion = TipoVehiculo.SelectedItem.ToString();

            if (seleccion == "Carro") precioBaseVehiculo = 10000.0;
            else if (seleccion == "Camioneta") precioBaseVehiculo = 15000.0;
            else if (seleccion == "Motocicleta") precioBaseVehiculo = 5000.0;
            else precioBaseVehiculo = 0;

            totalPagar = precioBaseVehiculo + (30000) + ((double)Cantidad_Personas.Value * 3000);
        }

        private void Boton_Registrar_Click(object sender, EventArgs e)
        {
            if (Nombre_box.Text == "" || Apellido_box.Text == "" || ID_box.Text == "" || TipoVehiculo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar al cliente.");
                return;
            }

            if (FechaInicio.Value.Date < DateTime.Now.Date)
            {
                Mensaje_Fecha1.Visible = true;
                MessageBox.Show("La fecha de inicio no puede ser un día atrás del actual.");
                return;
            }

            TimeSpan diferencia = FechaFinal.Value - FechaInicio.Value;
            if (diferencia.TotalDays > 20)
            {
                MessageBox.Show("La fecha final no puede exceder más de 20 días desde la fecha de inicio.");
                return;
            }

            if (FechaFinal.Value < FechaInicio.Value)
            {
                MessageBox.Show("La fecha final no puede ser menor a la fecha de inicio.");
                return;
            }

            MessageBox.Show($"    ¡Cliente Registrado Exitosamente!\n \nNombre: {Nombre_box.Text}\nApellido: {Apellido_box.Text}\nID: {ID_box.Text}\nCantidad de Personas: {Cantidad_Personas.Value}\nTipo de Vehículo: {TipoVehiculo.SelectedItem}\nFecha Inicio: {FechaInicio.Value.ToShortDateString()}\nFecha Final: {FechaFinal.Value.ToShortDateString()}\n \nTotal pagar: $ {totalPagar}");
        }

        private void FechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (FechaInicio.Value.Date < DateTime.Now.Date)
            {
                Mensaje_Fecha1.Visible = true;
            }
            else
            {
                Mensaje_Fecha1.Visible = false;
            }
        }

        private void FechaFinal_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan diferencia = FechaFinal.Value - FechaInicio.Value;
            if (diferencia.TotalDays > 20)
            {
                FechaFinal.Value = FechaInicio.Value.AddDays(20);
            }
        }
    }
}