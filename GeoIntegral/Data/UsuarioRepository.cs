using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GeoIntegral.Models;
using System.Text; // Para Encoding

namespace GeoIntegral.Data
{
    public class UsuarioRepository
    {
        // Ruta apuntando a la carpeta DataBase que mostraste en la imagen
        private readonly string _ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBase", "usuarios.csv");

        public List<Usuario> ObtenerTodos()
        {
            var lista = new List<Usuario>();
            try
            {
                if (!File.Exists(_ruta)) return lista;

                // Usamos ReadLines para no cargar todo en memoria si el archivo crece
                var lineas = File.ReadLines(_ruta, Encoding.UTF8).Skip(1);

                foreach (var linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    var datos = linea.Split(',');
                    if (datos.Length >= 2)
                    {
                        lista.Add(new Usuario
                        {
                            Username = datos[0].Trim(),
                            Password = datos[1].Trim()
                        });
                    }
                }
            }
            catch (Exception)
            {
                // Si da error (archivo abierto, etc), devolvemos la lista vacía o lo que llevemos
            }
            return lista;
        }

        public void Agregar(Usuario nuevoUsuario)
        {
            try
            {
                // Verificamos si la carpeta existe antes de escribir
                string carpeta = Path.GetDirectoryName(_ruta);
                if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);

                // Si el archivo no existe, creamos encabezados
                if (!File.Exists(_ruta))
                {
                    File.WriteAllLines(_ruta, new[] { "Usuario,Password" }, Encoding.UTF8);
                }

                using (StreamWriter sw = new StreamWriter(_ruta, true, Encoding.UTF8))
                {
                    sw.WriteLine($"{nuevoUsuario.Username.Trim()},{nuevoUsuario.Password.Trim()}");
                }
            }
            catch (IOException ex)
            {
                System.Media.SystemSounds.Hand.Play();
                throw new Exception("El archivo CSV está abierto en otro programa. Ciérralo e intenta de nuevo.");
            }
        }
    }
}