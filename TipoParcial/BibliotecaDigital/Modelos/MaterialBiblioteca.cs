using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial.BibliotecaDigital.Interfaces;

namespace TipoParcial.BibliotecaDigital.Modelos
{
    public class MaterialBiblioteca
    {
        protected string titulo { get; set; }
        protected string autor { get; set; }
        protected int id { get; set; }
        protected int anioPublicacion { get; set; }
        protected string categoria { get; set; }

        public MaterialBiblioteca(string titulo, string autor, int id, int anioPublicacion, string categoria)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.id = id;
            this.anioPublicacion = anioPublicacion;
            this.categoria = categoria;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Año de Publicación: {anioPublicacion}");
            Console.WriteLine($"Categoría: {categoria}");
        }
    }
}